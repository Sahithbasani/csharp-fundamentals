namespace CSharpFundamentals.Modules.Operators;

/// <summary>
/// Demonstrates operators and expression semantics in a backend-oriented scenario.
/// </summary>
public static class ComparisonOperatorsExample
{
    public static bool IsWithinLimit(decimal amount, decimal limit) => amount > 0 && amount <= limit;
}
