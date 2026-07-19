using CSharpFundamentals.Examples;

namespace CSharpFundamentals.Verification;

internal sealed class ExampleVerificationRunner
{
    public async Task<int> RunAsync(TextWriter output, CancellationToken cancellationToken)
    {
        var checks = new List<VerificationCheckResult>();

        RunCheck(
            checks,
            "Order totals stay deterministic for a valid request",
            () =>
            {
                var service = new OrderProcessingService();
                var result = service.Process(
                    new PlaceOrderRequest(
                        Guid.Parse("5a91d8d4-2727-4061-95f0-59a616e8024f"),
                        [
                            new OrderLine("API-SUPPORT", 1, 200m),
                            new OrderLine("REPORTING", 1, 250m)
                        ]));

                AssertEqual(450m, result.Subtotal, "Expected order subtotal to match line totals.");
                AssertEqual(37.13m, result.Tax, "Expected order tax to be rounded away from zero.");
                AssertEqual(487.13m, result.Total, "Expected order total to include tax.");
                AssertEqual(false, result.RequiresManualReview, "Expected smaller orders to avoid manual review.");
            });

        RunCheck(
            checks,
            "Order validation rejects missing order lines",
            () =>
            {
                var service = new OrderProcessingService();

                ArgumentException exception = AssertThrows<ArgumentException>(
                    () => service.Process(
                        new PlaceOrderRequest(
                            Guid.Parse("67c2c86d-cc51-4f8c-b0cb-1d8e2e30197f"),
                            [])));

                AssertStartsWith(
                    "At least one order line is required.",
                    exception.Message,
                    "Expected an actionable validation message for empty orders.");
            });

        RunCheck(
            checks,
            "Payment validation approves a supported low-risk payment",
            () =>
            {
                var engine = new PaymentDecisionEngine();
                var decision = engine.Evaluate(
                    new PaymentRequest(
                        Guid.Parse("0b3d73f9-84e2-41b0-8f3d-f9b1dbc1aa90"),
                        250m,
                        "USD",
                        RiskLevel.Low));

                AssertEqual("Approved", decision.Status, "Expected low-risk supported payments to be approved.");
            });

        RunCheck(
            checks,
            "Payment validation routes high-risk payments to review",
            () =>
            {
                var engine = new PaymentDecisionEngine();
                var decision = engine.Evaluate(
                    new PaymentRequest(
                        Guid.Parse("5a18890d-8be0-46df-9810-cd32e0409f9a"),
                        250m,
                        "USD",
                        RiskLevel.High));

                AssertEqual("Manual review", decision.Status, "Expected high-risk payments to be reviewed.");
            });

        RunCheck(
            checks,
            "Payment validation rejects unsupported currencies",
            () =>
            {
                var engine = new PaymentDecisionEngine();
                var decision = engine.Evaluate(
                    new PaymentRequest(
                        Guid.Parse("d0e0f54b-9c75-4839-bfd8-ecb957b1ac63"),
                        250m,
                        "EUR",
                        RiskLevel.Low));

                AssertEqual("Rejected", decision.Status, "Expected unsupported currencies to be rejected.");
            });

        await RunCheckAsync(
            checks,
            "Notification dispatch respects disabled preferences",
            async () =>
            {
                var userId = Guid.Parse("a3282695-7245-4889-bd29-481c4ff8bf40");
                var service = new NotificationService(
                    new InMemoryUserRepository(
                        [new User(userId, "ops@example.com", false)]),
                    new RecordingMessageGateway());

                var result = await service.NotifyAsync(userId, "Deploy finished.", cancellationToken);

                AssertEqual(
                    "Notifications disabled",
                    result.Status,
                    "Expected disabled recipients to stop dispatch before gateway calls.");
            });

        await RunCheckAsync(
            checks,
            "Notification dispatch sends a message for an enabled user",
            async () =>
            {
                var userId = Guid.Parse("a97fe9de-2227-4d77-b503-cb6cd42bd0c7");
                var gateway = new RecordingMessageGateway();
                var service = new NotificationService(
                    new InMemoryUserRepository(
                        [new User(userId, "alerts@example.com", true)]),
                    gateway);

                var result = await service.NotifyAsync(userId, "Order 7421 approved.", cancellationToken);

                AssertEqual("Sent", result.Status, "Expected enabled users to receive notifications.");
                AssertEqual(1, gateway.SentMessages.Count, "Expected a single gateway dispatch.");
                AssertEqual("alerts@example.com", gateway.SentMessages[0].Destination, "Expected the user email to be the destination.");
            });

        foreach (var check in checks)
        {
            string status = check.Passed ? "[PASS]" : "[FAIL]";
            output.WriteLine($"{status} {check.Name}");

            if (!string.IsNullOrWhiteSpace(check.Detail))
                output.WriteLine($"       {check.Detail}");
        }

        output.WriteLine();
        output.WriteLine($"{checks.Count(result => result.Passed)}/{checks.Count} checks passed.");

        return checks.All(result => result.Passed) ? 0 : 1;
    }

    private static void RunCheck(
        ICollection<VerificationCheckResult> checks,
        string name,
        Action action)
    {
        try
        {
            action();
            checks.Add(new VerificationCheckResult(name, true, null));
        }
        catch (Exception exception)
        {
            checks.Add(new VerificationCheckResult(name, false, exception.Message));
        }
    }

    private static async Task RunCheckAsync(
        ICollection<VerificationCheckResult> checks,
        string name,
        Func<Task> action)
    {
        try
        {
            await action();
            checks.Add(new VerificationCheckResult(name, true, null));
        }
        catch (Exception exception)
        {
            checks.Add(new VerificationCheckResult(name, false, exception.Message));
        }
    }

    private static void AssertEqual<T>(T expected, T actual, string message)
    {
        if (!EqualityComparer<T>.Default.Equals(expected, actual))
            throw new InvalidOperationException($"{message} Expected: {expected}; Actual: {actual}.");
    }

    private static void AssertStartsWith(string expectedPrefix, string actual, string message)
    {
        if (!actual.StartsWith(expectedPrefix, StringComparison.Ordinal))
            throw new InvalidOperationException($"{message} Expected prefix: {expectedPrefix}; Actual: {actual}.");
    }

    private static TException AssertThrows<TException>(Action action)
        where TException : Exception
    {
        try
        {
            action();
        }
        catch (TException exception)
        {
            return exception;
        }

        throw new InvalidOperationException($"Expected {typeof(TException).Name} to be thrown.");
    }

    private sealed record VerificationCheckResult(string Name, bool Passed, string? Detail);

    private sealed class RecordingMessageGateway : IMessageGateway
    {
        public List<SentMessage> SentMessages { get; } = [];

        public Task SendAsync(string destination, string message, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            SentMessages.Add(new SentMessage(destination, message));
            return Task.CompletedTask;
        }
    }

    private sealed record SentMessage(string Destination, string Message);
}
