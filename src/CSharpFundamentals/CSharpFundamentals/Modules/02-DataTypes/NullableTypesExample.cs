namespace CSharpFundamentals.Modules.DataTypes;

/// <summary>
/// Demonstrates data types and representation in a backend-oriented scenario.
/// </summary>
public static class NullableTypesExample
{
    public static DateTimeOffset ResolveScheduledAt(DateTimeOffset? requested, DateTimeOffset fallback) => requested ?? fallback;
}
