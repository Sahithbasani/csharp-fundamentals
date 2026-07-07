namespace CSharpFundamentals.Examples;

internal sealed class PaymentDecisionEngine
{
    public PaymentDecision Evaluate(PaymentRequest request) =>
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
}

internal sealed record PaymentRequest(
    Guid PaymentId,
    decimal Amount,
    string Currency,
    RiskLevel RiskLevel);

internal sealed record PaymentDecision(string Status, string Reason)
{
    public static PaymentDecision Approved() =>
        new("Approved", "Payment passed validation.");

    public static PaymentDecision Review(string reason) =>
        new("Manual review", reason);

    public static PaymentDecision Rejected(string reason) =>
        new("Rejected", reason);
}

internal enum RiskLevel
{
    Low,
    Medium,
    High
}
