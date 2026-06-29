namespace CSharpFundamentals.Modules.Strings;

/// <summary>
/// Demonstrates strings, text, culture, and encoding in a backend-oriented scenario.
/// </summary>
public static class InterpolationExample
{
    public static string FormatOrder(Guid orderId, decimal total) => $"Order {orderId:N} totals {total:C}.";
}
