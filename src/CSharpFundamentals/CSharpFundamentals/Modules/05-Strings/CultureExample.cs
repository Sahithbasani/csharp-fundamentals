namespace CSharpFundamentals.Modules.Strings;

/// <summary>
/// Demonstrates strings, text, culture, and encoding in a backend-oriented scenario.
/// </summary>
public static class CultureExample
{
    public static string FormatForCulture(decimal amount, string culture) => amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo(culture));
}
