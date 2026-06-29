namespace CSharpFundamentals.Modules.Methods;

/// <summary>
/// Demonstrates methods, contracts, and api shape in a backend-oriented scenario.
/// </summary>
public static class MethodContractsExample
{
    public static decimal CalculateOutstanding(decimal invoiced, decimal paid) { if (paid < 0) throw new ArgumentOutOfRangeException(nameof(paid)); return invoiced - paid; }
}
