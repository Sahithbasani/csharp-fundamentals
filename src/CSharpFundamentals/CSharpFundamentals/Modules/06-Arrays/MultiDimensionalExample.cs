namespace CSharpFundamentals.Modules.Arrays;

/// <summary>
/// Demonstrates arrays, spans, and contiguous memory in a backend-oriented scenario.
/// </summary>
public static class MultiDimensionalExample
{
    public static int TotalCapacity(int[,] capacity) { int total = 0; foreach (int value in capacity) total += value; return total; }
}
