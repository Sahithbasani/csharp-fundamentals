namespace CSharpFundamentals.Modules.Namespaces;

/// <summary>
/// Demonstrates namespaces, assemblies, and dependency boundaries in a backend-oriented scenario.
/// </summary>
public static class InternalVisibilityExample
{
    internal static bool IsInternalBatch(string source) => string.Equals(source, "internal", StringComparison.OrdinalIgnoreCase);
}
