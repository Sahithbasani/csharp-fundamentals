namespace CSharpFundamentals.Modules.Variables;

/// <summary>
/// Demonstrates variables and state in a backend-oriented scenario.
/// </summary>
public static class ScopeExample
{
    public static string CreateCorrelationLabel(Guid requestId) { string prefix = "order"; return $"{prefix}:{requestId:N}"; }
}
