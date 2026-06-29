namespace CSharpFundamentals.Modules.Strings;

/// <summary>
/// Demonstrates strings, text, culture, and encoding in a backend-oriented scenario.
/// </summary>
public static class StringPerformanceExample
{
    public static bool HasOrderPrefix(ReadOnlySpan<char> value) => value.StartsWith("order-", StringComparison.Ordinal);
}
