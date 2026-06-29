namespace CSharpFundamentals.Modules.Strings;

/// <summary>
/// Demonstrates strings, text, culture, and encoding in a backend-oriented scenario.
/// </summary>
public static class SearchingExample
{
    public static bool ContainsHeader(string headers, string name) => headers.Contains(name, StringComparison.OrdinalIgnoreCase);
}
