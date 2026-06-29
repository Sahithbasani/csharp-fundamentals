namespace CSharpFundamentals.Modules.ExceptionHandling;

/// <summary>
/// Demonstrates exceptions, resilience, and failure semantics in a backend-oriented scenario.
/// </summary>
public static class ResilientOperationExample
{
    public static async Task<T> ExecuteAsync<T>(Func<CancellationToken, Task<T>> operation, CancellationToken token) { try { return await operation(token); } catch (TimeoutException) when (!token.IsCancellationRequested) { return await operation(token); } }
}
