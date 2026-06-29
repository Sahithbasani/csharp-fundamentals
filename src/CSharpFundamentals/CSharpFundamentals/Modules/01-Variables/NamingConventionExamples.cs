namespace CSharpFundamentals.Modules.Variables;

/// <summary>
/// Demonstrates variables and state in a backend-oriented scenario.
/// </summary>
public static class NamingConventionExamples
{
    public static bool IsEligibleForExpressFulfillment(int availableUnits, int requestedUnits) => requestedUnits > 0 && availableUnits >= requestedUnits;
}
