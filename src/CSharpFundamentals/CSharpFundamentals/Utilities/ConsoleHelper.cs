namespace CSharpFundamentals.Utilities;

internal static class ConsoleHelper
{
    public static void PrintHeader(string title)
    {
        Console.WriteLine(new string('=', 60));
        Console.WriteLine($"  {title}");
        Console.WriteLine(new string('=', 60));
        Console.WriteLine();
    }
}
