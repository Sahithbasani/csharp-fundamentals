# Runnable Backend Examples

[Repository home](../README.md) | [Module index](../README.md#module-index)

These examples are small enough to run locally while using domains and design concerns found in backend services.

## Run Everything

```bash
dotnet run --project src/CSharpFundamentals/CSharpFundamentals/CSharpFundamentals.csproj
```

## Verify Expected Behavior

```bash
dotnet run --project src/CSharpFundamentals/CSharpFundamentals/CSharpFundamentals.csproj -- verify
```

The `verify` command checks the reusable order, payment, and notification decision paths so regressions surface before a pull request is opened.

## Available Examples

| Argument | Scenario | Concepts |
| --- | --- | --- |
| `order` | Validate order lines and calculate tax and totals | Records, collections, LINQ, decimal arithmetic, validation |
| `payment` | Evaluate a payment before calling a gateway | Pattern matching, result objects, business rules |
| `notification` | Load a user and dispatch a message | Interfaces, dependency injection, async/await, cancellation |

### Order Processing

```bash
dotnet run --project src/CSharpFundamentals/CSharpFundamentals/CSharpFundamentals.csproj -- order
```

Expected behavior:

- validates customer and line data
- calculates subtotal, tax, and total
- flags orders at or above the review threshold

### Payment Validation

```bash
dotnet run --project src/CSharpFundamentals/CSharpFundamentals/CSharpFundamentals.csproj -- payment
```

Expected behavior:

- rejects invalid amounts or unsupported currencies
- routes high-risk or large payments to manual review
- returns a decision object rather than using exceptions for expected outcomes

### Notification Dispatch

```bash
dotnet run --project src/CSharpFundamentals/CSharpFundamentals/CSharpFundamentals.csproj -- notification
```

Expected behavior:

- resolves a user through a repository interface
- respects notification preferences
- rejects empty user IDs and blank message content before repository access
- does not send when an enabled user has no usable email address
- sends through an asynchronous gateway with cancellation support

The service treats the user ID and message as caller-controlled input, so malformed
values fail at the boundary with an actionable exception. A blank email belongs to
the loaded user record instead, so it returns `User email unavailable` without
calling the gateway. This distinction keeps invalid requests separate from data that
cannot be delivered safely.

Related reading: Microsoft's [C# 11 preview update](https://devblogs.microsoft.com/dotnet/csharp-11-preview-updates/)
explains why .NET guard helpers such as `ArgumentNullException.ThrowIfNull` are a
clear option for boundary validation. This example additionally uses
`ArgumentException.ThrowIfNullOrWhiteSpace` for content that must be nonblank.

## Practice Extensions

1. Add an order discount policy without changing the tax calculation.
2. Add a payment rule for a daily customer limit.
3. Replace the console message gateway with an in-memory test double.
4. Pass a canceled token and explain where cancellation is observed.

> [!TIP]
> Keep each extension focused. First write down the business rule, then choose the C# feature that expresses it most clearly.
