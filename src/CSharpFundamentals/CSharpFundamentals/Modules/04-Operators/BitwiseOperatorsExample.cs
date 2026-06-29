namespace CSharpFundamentals.Modules.Operators;

/// <summary>
/// Demonstrates operators and expression semantics in a backend-oriented scenario.
/// </summary>
public static class BitwiseOperatorsExample
{
    [Flags] public enum Permission { None = 0, Read = 1, Write = 2, Approve = 4 }
    public static bool CanApprove(Permission value) => (value & Permission.Approve) != 0;
}
