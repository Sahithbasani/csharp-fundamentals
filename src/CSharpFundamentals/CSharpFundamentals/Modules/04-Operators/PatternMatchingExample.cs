namespace CSharpFundamentals.Modules.Operators;

/// <summary>
/// Demonstrates operators and expression semantics in a backend-oriented scenario.
/// </summary>
public static class PatternMatchingExample
{
    public static string Classify(decimal amount) => amount switch { <= 0 => "Invalid", > 10_000m => "Review", _ => "Standard" };
}
