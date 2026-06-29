namespace CSharpFundamentals.Modules.DataTypes;

/// <summary>
/// Demonstrates data types and representation in a backend-oriented scenario.
/// </summary>
public static class BoxingUnboxingExample
{
    public static object BoxOrderNumber(int orderNumber) => orderNumber;
    public static int UnboxOrderNumber(object value) => value is int number ? number : throw new ArgumentException("Expected an order number.");
}
