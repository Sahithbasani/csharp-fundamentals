namespace CSharpFundamentals.Modules.Strings;

/// <summary>
/// Demonstrates strings, text, culture, and encoding in a backend-oriented scenario.
/// </summary>
public static class EncodingExample
{
    public static byte[] EncodePayload(string payload) => System.Text.Encoding.UTF8.GetBytes(payload);
}
