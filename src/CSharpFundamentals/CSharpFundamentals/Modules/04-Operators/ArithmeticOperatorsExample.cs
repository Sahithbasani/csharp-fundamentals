namespace CSharpFundamentals.Modules.Operators;

/// <summary>
/// Demonstrates operators and expression semantics in a backend-oriented scenario.
/// </summary>
public static class ArithmeticOperatorsExample
{
    public static decimal CalculateNet(decimal subtotal, decimal discount, decimal tax) => subtotal - discount + tax;
}
