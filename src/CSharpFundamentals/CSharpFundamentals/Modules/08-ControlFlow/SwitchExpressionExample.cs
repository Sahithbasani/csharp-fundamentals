namespace CSharpFundamentals.Modules.ControlFlow;

/// <summary>
/// Demonstrates control flow and business decisions in a backend-oriented scenario.
/// </summary>
public static class SwitchExpressionExample
{
    public static string RouteClaim(decimal amount, bool fraudFlag) => (amount, fraudFlag) switch { (_, true) => "FraudReview", ( > 10_000m, _) => "SeniorReview", _ => "Standard" };
}
