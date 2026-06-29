namespace CSharpFundamentals.Modules.Arrays;

/// <summary>
/// Demonstrates arrays, spans, and contiguous memory in a backend-oriented scenario.
/// </summary>
public static class ArrayPerformanceExample
{
    public static long SumUnits(int[] units) { long total = 0; for (int i = 0; i < units.Length; i++) total += units[i]; return total; }
}
