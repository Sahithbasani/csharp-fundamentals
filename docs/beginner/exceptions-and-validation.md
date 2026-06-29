# Exceptions and Validation

[← Curriculum](../README.md) · [Home](../../README.md) · [← Collections and LINQ](../beginner/collections-and-linq.md) · [Object-Oriented Design and SOLID →](../intermediate/object-oriented-design.md)

**Level:** Beginner

## Overview

Validation protects boundaries; exceptions report failures that are not ordinary business outcomes at the current layer.

## Why It Matters

Production APIs need predictable client errors, preserved diagnostic context, and cleanup without leaking sensitive details.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | Boundary versus domain validation |
| 2 | Exception propagation |
| 3 | Expected outcomes versus failures |



## Practical Backend Example

```csharp
public async Task<ClaimResult> ProcessAsync(
    SubmitClaim command,
    CancellationToken cancellationToken)
{
    if (command.Amount <= 0) return ClaimResult.Rejected("Amount must be positive.");

    var duplicate = await repository.ExistsAsync(
        command.ExternalReference, cancellationToken);

    return duplicate ? ClaimResult.Rejected("Duplicate claim.") : ClaimResult.Accepted();
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Log unexpected failures once at the application boundary.
- Keep secrets out of messages.
- Allow cancellation to propagate.

## Common Mistakes

- Catching `Exception` and continuing.
- Using exceptions for common validation.
- Discarding original stack traces.

## Best Practices

- Use stable Problem Details contracts.
- Test failure paths.
- Make messages actionable but safe.

## Interview Questions

1. Where should validation occur?
2. Why should cancellation usually propagate?
3. How do business failures differ from exceptions?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Collections and LINQ](../beginner/collections-and-linq.md) · [Object-Oriented Design and SOLID →](../intermediate/object-oriented-design.md)
