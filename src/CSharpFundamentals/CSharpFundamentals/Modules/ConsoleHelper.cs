using System;

namespace CSharpFundamentals.Utilities
{
    internal static class ConsoleHelper
    {
        public static void PrintHeader(string title)
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"  {title}");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine();
        }

        public static void PrintMenu(string[] items)
        {
            Console.WriteLine("Topics Included:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
            Console.WriteLine();
        }

        public static int PromptSelection(int min, int max)
        {
            Console.Write($"Select a module ({min}-{max}): ");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && choice >= min && choice <= max)
                    return choice;
                Console.Write($"Invalid selection. Enter a number between {min} and {max}: ");
            }
        }

        public static void Pause()
        {
            if (Console.IsInputRedirected)
            {
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
