namespace CSharpFundamentals.Modules.Operators;

/// <summary>
/// Demonstrates operators and expression semantics in a backend-oriented scenario.
/// </summary>
public static class OperatorPrecedenceExample
{
    public static bool CanRelease(bool paid, bool creditApproved, bool complianceHold) => (paid || creditApproved) && !complianceHold;
}
