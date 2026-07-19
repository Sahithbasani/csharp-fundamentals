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
- sends through an asynchronous gateway with cancellation support

## Practice Extensions

1. Add an order discount policy without changing the tax calculation.
2. Add a payment rule for a daily customer limit.
3. Replace the console message gateway with an in-memory test double.
4. Pass a canceled token and explain where cancellation is observed.

> [!TIP]
> Keep each extension focused. First write down the business rule, then choose the C# feature that expresses it most clearly.
