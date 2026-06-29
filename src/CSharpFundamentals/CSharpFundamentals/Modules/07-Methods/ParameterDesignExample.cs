namespace CSharpFundamentals.Modules.Methods;

/// <summary>
/// Demonstrates methods, contracts, and api shape in a backend-oriented scenario.
/// </summary>
public static class ParameterDesignExample
{
    public sealed record CreateUserCommand(string Email, string DisplayName);
    public static bool IsValid(CreateUserCommand command) => !string.IsNullOrWhiteSpace(command.Email) && !string.IsNullOrWhiteSpace(command.DisplayName);
}
