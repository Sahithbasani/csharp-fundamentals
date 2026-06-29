namespace CSharpFundamentals.Modules.DataTypes;

/// <summary>
/// Demonstrates data types and representation in a backend-oriented scenario.
/// </summary>
public static class MemoryAllocationExample
{
    public static string BuildCacheKey(Guid customerId, int page) => $"customers:{customerId:N}:orders:{page}";
}
