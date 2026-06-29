namespace CSharpFundamentals.Modules.Strings;

/// <summary>
/// Demonstrates strings, text, culture, and encoding in a backend-oriented scenario.
/// </summary>
public static class SplittingExample
{
    public static string[] ParseScopes(string scopes) => scopes.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
}
