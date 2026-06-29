namespace CSharpFundamentals.Modules.ExceptionHandling;

/// <summary>
/// Demonstrates exceptions, resilience, and failure semantics in a backend-oriented scenario.
/// </summary>
public static class ExceptionFilterExample
{
    public static bool IsTransient(Exception exception) => exception is HttpRequestException { StatusCode: System.Net.HttpStatusCode.ServiceUnavailable };
}
