namespace CSharpFundamentals.Modules.TypeConversion;

/// <summary>
/// Demonstrates type conversion and boundary parsing in a backend-oriented scenario.
/// </summary>
public static class ParseTryParseExample
{
    public static bool TryReadAmount(string input, out decimal amount) => decimal.TryParse(input, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out amount);
}
