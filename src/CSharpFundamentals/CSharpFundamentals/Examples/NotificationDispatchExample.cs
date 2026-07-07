namespace CSharpFundamentals.Examples;

public sealed class NotificationDispatchExample : IBackendExample
{
    public string Name => "Notification dispatch";

    public string Description =>
        "Loads a user through a repository contract and sends a message through an async gateway.";

    public async Task RunAsync(CancellationToken cancellationToken)
    {
        var userId = Guid.Parse("79438ba9-d0b9-47de-b4fb-1f46e7cf82e1");
        var users = new InMemoryUserRepository(
            [new User(userId, "orders@example.com", true)]);

        var service = new NotificationService(users, new ConsoleMessageGateway());
        NotificationResult result = await service.NotifyAsync(
            userId,
            "Order 7421 has been approved.",
            cancellationToken);

        Console.WriteLine($"Notification status: {result.Status}");
    }
}
