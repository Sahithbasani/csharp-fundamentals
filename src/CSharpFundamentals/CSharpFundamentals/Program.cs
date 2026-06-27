using System;
using CSharpFundamentals.Modules.Variables;
using CSharpFundamentals.Utilities;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C# Fundamentals";

            var topics = new[]
            {
                "Variables",
                "Data Types",
                "Type Conversion",
                "Operators",
                "Strings",
                "Arrays",
                "Methods",
                "Control Flow",
                "Exception Handling",
                "Namespaces"
            };

            ConsoleHelper.PrintHeader("C# Fundamentals Repository");
            ConsoleHelper.PrintMenu(topics);

            int choice = ConsoleHelper.PromptSelection(1, topics.Length);

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    VariablesExample.Run();
                    break;
                default:
                    Console.WriteLine("This module is not implemented yet. Visit the Modules folder to add examples.");
                    break;
            }

            ConsoleHelper.Pause();
        }
    }
}
