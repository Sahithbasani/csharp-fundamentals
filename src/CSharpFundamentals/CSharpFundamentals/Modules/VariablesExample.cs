using System;

namespace CSharpFundamentals.Modules.Variables
{
    public static class VariablesExample
    {
        public static void Run()
        {
            Console.WriteLine("Module 01 - Variables");

            int count = 42;
            string name = "Alice";
            bool isActive = true;

            Console.WriteLine($"Integer: {count}");
            Console.WriteLine($"String: {name}");
            Console.WriteLine($"Boolean: {isActive}");
        }
    }
}
