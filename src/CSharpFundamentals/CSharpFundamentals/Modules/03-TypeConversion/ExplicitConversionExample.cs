namespace CSharpFundamentals.Modules.TypeConversion;

/// <summary>
/// Demonstrates type conversion and boundary parsing in a backend-oriented scenario.
/// </summary>
public static class ExplicitConversionExample
{
    public static int NarrowInventory(long units) => checked((int)units);
}
