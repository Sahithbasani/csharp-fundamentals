namespace CSharpFundamentals.Examples;

public sealed class PaymentValidationExample : IBackendExample
{
    private readonly PaymentDecisionEngine _engine = new();

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

        PaymentDecision decision = _engine.Evaluate(request);

        Console.WriteLine($"Payment ID: {request.PaymentId}");
        Console.WriteLine($"Decision: {decision.Status}");
        Console.WriteLine($"Reason: {decision.Reason}");

        return Task.CompletedTask;
    }
}
