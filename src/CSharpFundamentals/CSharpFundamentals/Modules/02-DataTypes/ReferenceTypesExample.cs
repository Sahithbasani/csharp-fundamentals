namespace CSharpFundamentals.Modules.DataTypes;

/// <summary>
/// Demonstrates data types and representation in a backend-oriented scenario.
/// </summary>
public static class ReferenceTypesExample
{
    public static IReadOnlyList<string> SnapshotRecipients(IEnumerable<string> recipients) => recipients.ToArray();
}
