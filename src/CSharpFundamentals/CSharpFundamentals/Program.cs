using CSharpFundamentals.Examples;
using CSharpFundamentals.Utilities;
using CSharpFundamentals.Verification;

Console.Title = "C# Fundamentals: Backend Examples";

IReadOnlyDictionary<string, IBackendExample> examples =
    new Dictionary<string, IBackendExample>(StringComparer.OrdinalIgnoreCase)
    {
        ["order"] = new OrderProcessingExample(),
        ["payment"] = new PaymentValidationExample(),
        ["notification"] = new NotificationDispatchExample()
    };

if (args.Length > 0)
{
    if (string.Equals(args[0], "verify", StringComparison.OrdinalIgnoreCase))
        return await new ExampleVerificationRunner().RunAsync(Console.Out, CancellationToken.None);

    if (!examples.TryGetValue(args[0], out var selected))
    {
        Console.Error.WriteLine($"Unknown example '{args[0]}'.");
        Console.Error.WriteLine($"Available commands: verify, {string.Join(", ", examples.Keys)}");
        return 1;
    }

    await RunAsync(selected);
    return 0;
}

foreach (var example in examples.Values)
{
    await RunAsync(example);
}

return 0;

static async Task RunAsync(IBackendExample example)
{
    ConsoleHelper.PrintHeader(example.Name);
    Console.WriteLine(example.Description);
    Console.WriteLine();
    await example.RunAsync(CancellationToken.None);
    Console.WriteLine();
}
