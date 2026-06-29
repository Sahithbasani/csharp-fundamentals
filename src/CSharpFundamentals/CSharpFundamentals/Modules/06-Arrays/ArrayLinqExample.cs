namespace CSharpFundamentals.Modules.Arrays;

/// <summary>
/// Demonstrates arrays, spans, and contiguous memory in a backend-oriented scenario.
/// </summary>
public static class ArrayLinqExample
{
    public static decimal[] LargePayments(decimal[] values) => values.Where(value => value >= 1_000m).ToArray();
}
