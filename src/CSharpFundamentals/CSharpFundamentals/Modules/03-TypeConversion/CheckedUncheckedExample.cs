namespace CSharpFundamentals.Modules.TypeConversion;

/// <summary>
/// Demonstrates type conversion and boundary parsing in a backend-oriented scenario.
/// </summary>
public static class CheckedUncheckedExample
{
    public static int AddReservedUnits(int current, int requested) => checked(current + requested);
}
