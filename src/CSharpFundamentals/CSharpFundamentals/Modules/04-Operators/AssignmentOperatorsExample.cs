namespace CSharpFundamentals.Modules.Operators;

/// <summary>
/// Demonstrates operators and expression semantics in a backend-oriented scenario.
/// </summary>
public static class AssignmentOperatorsExample
{
    public static int Reserve(int available, int requested) { available -= requested; return available; }
}
