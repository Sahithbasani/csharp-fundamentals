namespace CSharpFundamentals.Modules.Arrays;

/// <summary>
/// Demonstrates arrays, spans, and contiguous memory in a backend-oriented scenario.
/// </summary>
public static class SpanExample
{
    public static bool TryReadCode(ReadOnlySpan<char> input, out int code) => int.TryParse(input, out code);
}
