namespace CSharpFundamentals.Modules.Methods;

/// <summary>
/// Demonstrates methods, contracts, and api shape in a backend-oriented scenario.
/// </summary>
public static class AsyncMethodExample
{
    public static async Task<string> ReadResponseAsync(HttpClient client, Uri endpoint, CancellationToken token) => await client.GetStringAsync(endpoint, token);
}
