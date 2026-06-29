namespace CSharpFundamentals.Examples;

public sealed class PaymentValidationExample : IBackendExample
{
    public string Name => "Payment validation";

    public string Description =>
        "Evaluates amount, currency, and risk before a payment reaches an external gateway.";

    public Task RunAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var request = new PaymentRequest(
            Guid.Parse("8c4d21ec-5458-44d6-b21b-bbf6ceee2397"),
            2_500m,
            "USD",
            RiskLevel.High);

        PaymentDecision decision = Evaluate(request);

        Console.WriteLine($"Payment ID: {request.PaymentId}");
        Console.WriteLine($"Decision: {decision.Status}");
        Console.WriteLine($"Reason: {decision.Reason}");

        return Task.CompletedTask;
    }

    private static PaymentDecision Evaluate(PaymentRequest request) =>
        request switch
        {
            { Amount: <= 0 } =>
                PaymentDecision.Rejected("Amount must be positive."),
            { Currency: not "USD" and not "CAD" } =>
                PaymentDecision.Rejected("Currency is not supported."),
            { RiskLevel: RiskLevel.High } =>
                PaymentDecision.Review("High-risk payment requires manual review."),
            { Amount: > 10_000m } =>
                PaymentDecision.Review("Large payment requires manual review."),
            _ =>
                PaymentDecision.Approved()
        };

    private sealed record PaymentRequest(
        Guid PaymentId,
        decimal Amount,
        string Currency,
        RiskLevel RiskLevel);

    private sealed record PaymentDecision(string Status, string Reason)
    {
        public static PaymentDecision Approved() =>
            new("Approved", "Payment passed validation.");

        public static PaymentDecision Review(string reason) =>
            new("Manual review", reason);

        public static PaymentDecision Rejected(string reason) =>
            new("Rejected", reason);
    }

    private enum RiskLevel
    {
        Low,
        Medium,
        High
    }
}
