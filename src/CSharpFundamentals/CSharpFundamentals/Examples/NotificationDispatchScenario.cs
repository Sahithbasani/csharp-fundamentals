namespace CSharpFundamentals.Examples;

internal interface IUserRepository
{
    Task<User?> FindAsync(Guid userId, CancellationToken cancellationToken);
}

internal interface IMessageGateway
{
    Task SendAsync(string destination, string message, CancellationToken cancellationToken);
}

internal sealed class NotificationService(
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

internal sealed class InMemoryUserRepository(IEnumerable<User> users) : IUserRepository
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

internal sealed class ConsoleMessageGateway : IMessageGateway
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

internal sealed record User(Guid Id, string Email, bool NotificationsEnabled);

internal sealed record NotificationResult(string Status);
