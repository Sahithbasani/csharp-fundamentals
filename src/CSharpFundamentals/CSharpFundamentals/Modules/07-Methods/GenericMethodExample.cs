namespace CSharpFundamentals.Modules.Methods;

/// <summary>
/// Demonstrates methods, contracts, and api shape in a backend-oriented scenario.
/// </summary>
public static class GenericMethodExample
{
    public static T Require<T>(T? value, string name) where T : class => value ?? throw new ArgumentNullException(name);
}
