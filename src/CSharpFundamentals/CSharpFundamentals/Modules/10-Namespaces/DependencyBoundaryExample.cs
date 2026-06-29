namespace CSharpFundamentals.Modules.Namespaces;

/// <summary>
/// Demonstrates namespaces, assemblies, and dependency boundaries in a backend-oriented scenario.
/// </summary>
public static class DependencyBoundaryExample
{
    public interface IOrderClock { DateTimeOffset UtcNow { get; } }
    public static bool IsExpired(DateTimeOffset expiresAt, IOrderClock clock) => expiresAt <= clock.UtcNow;
}
