namespace CSharpFundamentals.Modules.ExceptionHandling;

/// <summary>
/// Demonstrates exceptions, resilience, and failure semantics in a backend-oriented scenario.
/// </summary>
public static class CustomExceptionExample
{
    public sealed class PaymentDeclinedException(string reason) : Exception(reason) { }
    public static void EnsureApproved(bool approved) { if (!approved) throw new PaymentDeclinedException("Gateway declined the payment."); }
}
