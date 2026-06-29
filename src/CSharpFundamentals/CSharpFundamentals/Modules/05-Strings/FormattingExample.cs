namespace CSharpFundamentals.Modules.Strings;

/// <summary>
/// Demonstrates strings, text, culture, and encoding in a backend-oriented scenario.
/// </summary>
public static class FormattingExample
{
    public static string FormatInvariant(decimal amount) => amount.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
}
