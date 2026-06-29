namespace CSharpFundamentals.Modules.ControlFlow;

/// <summary>
/// Demonstrates control flow and business decisions in a backend-oriented scenario.
/// </summary>
public static class LoopControlExample
{
    public static Guid? FirstFailed(IEnumerable<(Guid Id, bool Success)> results) { foreach (var result in results) if (!result.Success) return result.Id; return null; }
}
