namespace CSharpFundamentals.Modules.TypeConversion;

/// <summary>
/// Demonstrates type conversion and boundary parsing in a backend-oriented scenario.
/// </summary>
public static class ConvertClassExample
{
    public static int ReadRetryCount(object value) => Convert.ToInt32(value, System.Globalization.CultureInfo.InvariantCulture);
}
