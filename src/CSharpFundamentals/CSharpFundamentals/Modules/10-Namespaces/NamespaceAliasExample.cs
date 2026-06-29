namespace CSharpFundamentals.Modules.Namespaces;

/// <summary>
/// Demonstrates namespaces, assemblies, and dependency boundaries in a backend-oriented scenario.
/// </summary>
public static class NamespaceAliasExample
{
    public static global::System.Guid ParseOrderId(string value) => global::System.Guid.Parse(value);
}
