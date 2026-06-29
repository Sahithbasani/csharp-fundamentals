namespace CSharpFundamentals.Modules.Arrays;

/// <summary>
/// Demonstrates arrays, spans, and contiguous memory in a backend-oriented scenario.
/// </summary>
public static class MemoryExample
{
    public static ReadOnlyMemory<byte> PayloadSlice(ReadOnlyMemory<byte> payload, int headerLength) => payload[headerLength..];
}
