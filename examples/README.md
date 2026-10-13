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

- validates customer identifiers, the line collection, product codes, quantities, and prices before calculating totals
- calculates subtotal, tax, and total
- flags orders at or above the review threshold

Input contract: `CustomerId` must be non-empty, `Lines` must be non-null and contain at least one non-null line, and every line needs a nonblank `ProductCode`, positive quantity, and positive unit price. Invalid request structure is a caller-contract violation, so the example throws `ArgumentException` or `ArgumentNullException` with a specific reason rather than allowing a downstream LINQ exception to obscure the input defect.

Related reading: Microsoft’s [C# 14 overview](https://devblogs.microsoft.com/dotnet/introducing-csharp-14/) demonstrates concise guard logic in property accessors. The order scenario keeps its guards at the service boundary, where the complete request can be checked before any calculation begins.

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
