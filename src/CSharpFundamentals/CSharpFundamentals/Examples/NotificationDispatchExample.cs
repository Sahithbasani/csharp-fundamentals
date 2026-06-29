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

    private interface IUserRepository
    {
        Task<User?> FindAsync(Guid userId, CancellationToken cancellationToken);
    }

    private interface IMessageGateway
    {
        Task SendAsync(string destination, string message, CancellationToken cancellationToken);
    }

    private sealed class NotificationService(
        IUserRepository users,
        IMessageGateway gateway)
    {
        public async Task<NotificationResult> NotifyAsync(
            Guid userId,
            string message,
            CancellationToken cancellationToken)
        {
            User? user = await users.FindAsync(userId, cancellationToken);

            if (user is null)
                return new NotificationResult("User not found");

            if (!user.NotificationsEnabled)
                return new NotificationResult("Notifications disabled");

            await gateway.SendAsync(user.Email, message, cancellationToken);
            return new NotificationResult("Sent");
        }
    }

    private sealed class InMemoryUserRepository(IEnumerable<User> users) : IUserRepository
    {
        private readonly IReadOnlyDictionary<Guid, User> _users =
            users.ToDictionary(user => user.Id);

        public Task<User?> FindAsync(Guid userId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            _users.TryGetValue(userId, out User? user);
            return Task.FromResult(user);
        }
    }

    private sealed class ConsoleMessageGateway : IMessageGateway
    {
        public async Task SendAsync(
            string destination,
            string message,
            CancellationToken cancellationToken)
        {
            await Task.Delay(25, cancellationToken);
            Console.WriteLine($"Sending to {destination}: {message}");
        }
    }

    private sealed record User(Guid Id, string Email, bool NotificationsEnabled);

    private sealed record NotificationResult(string Status);
}
