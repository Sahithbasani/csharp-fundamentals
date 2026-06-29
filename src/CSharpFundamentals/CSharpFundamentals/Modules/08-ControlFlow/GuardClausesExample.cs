namespace CSharpFundamentals.Modules.ControlFlow;

/// <summary>
/// Demonstrates control flow and business decisions in a backend-oriented scenario.
/// </summary>
public static class GuardClausesExample
{
    public static void ValidateAmount(decimal amount) { if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount)); }
}
