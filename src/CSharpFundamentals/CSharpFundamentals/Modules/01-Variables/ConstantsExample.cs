namespace CSharpFundamentals.Modules.Variables;

/// <summary>
/// Demonstrates variables and state in a backend-oriented scenario.
/// </summary>
public static class ConstantsExample
{
    private const decimal ReviewThreshold = 1_000m;
    public static bool RequiresReview(decimal total) => total >= ReviewThreshold;
}
