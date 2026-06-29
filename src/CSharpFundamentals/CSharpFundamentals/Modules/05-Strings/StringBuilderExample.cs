namespace CSharpFundamentals.Modules.Strings;

/// <summary>
/// Demonstrates strings, text, culture, and encoding in a backend-oriented scenario.
/// </summary>
public static class StringBuilderExample
{
    public static string BuildAudit(IEnumerable<string> events) { var builder = new System.Text.StringBuilder(); foreach (string item in events) builder.AppendLine(item); return builder.ToString(); }
}
