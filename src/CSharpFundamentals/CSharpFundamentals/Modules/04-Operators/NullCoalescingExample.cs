namespace CSharpFundamentals.Modules.Operators;

/// <summary>
/// Demonstrates operators and expression semantics in a backend-oriented scenario.
/// </summary>
public static class NullCoalescingExample
{
    public static string ResolveRegion(string? requestedRegion, string configuredRegion) => requestedRegion ?? configuredRegion;
}
