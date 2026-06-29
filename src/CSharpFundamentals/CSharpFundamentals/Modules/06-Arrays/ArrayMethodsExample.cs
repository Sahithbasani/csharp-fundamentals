namespace CSharpFundamentals.Modules.Arrays;

/// <summary>
/// Demonstrates arrays, spans, and contiguous memory in a backend-oriented scenario.
/// </summary>
public static class ArrayMethodsExample
{
    public static Guid[] CopyOrderIds(Guid[] source) { var copy = new Guid[source.Length]; Array.Copy(source, copy, source.Length); return copy; }
}
