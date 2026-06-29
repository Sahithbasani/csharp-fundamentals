namespace CSharpFundamentals.Modules.ExceptionHandling;

/// <summary>
/// Demonstrates exceptions, resilience, and failure semantics in a backend-oriented scenario.
/// </summary>
public static class ExceptionPropagationExample
{
    public static void Execute(Action operation) { try { operation(); } catch (InvalidOperationException) { throw; } }
}
