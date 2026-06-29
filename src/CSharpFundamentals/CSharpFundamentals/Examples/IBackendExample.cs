namespace CSharpFundamentals.Examples;

public interface IBackendExample
{
    string Name { get; }

    string Description { get; }

    Task RunAsync(CancellationToken cancellationToken);
}
