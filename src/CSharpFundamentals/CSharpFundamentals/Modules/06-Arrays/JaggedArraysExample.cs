namespace CSharpFundamentals.Modules.Arrays;

/// <summary>
/// Demonstrates arrays, spans, and contiguous memory in a backend-oriented scenario.
/// </summary>
public static class JaggedArraysExample
{
    public static int CountEvents(string[][] batches) => batches.Sum(batch => batch.Length);
}
