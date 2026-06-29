# Variables, Types, and Nullability

[← Curriculum](../README.md) · [Home](../../README.md) · [Control Flow and Method Design →](../beginner/control-flow-and-methods.md)

**Level:** Beginner

## Overview

Types make backend contracts explicit and move many failures from production into compiler warnings and validation.

## Why It Matters

Requests, configuration, and database values can be absent or malformed; precise types prevent invalid state from spreading.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | Value and reference semantics |
| 2 | Nullable reference contracts |
| 3 | Domain-specific value choices |



## Practical Backend Example

```csharp
public sealed record CreateOrderRequest(Guid CustomerId, decimal Total, string? Note);

public static void Validate(CreateOrderRequest request)
{
    ArgumentNullException.ThrowIfNull(request);
    if (request.CustomerId == Guid.Empty) throw new ArgumentException("CustomerId is required.");
    if (request.Total <= 0) throw new ArgumentOutOfRangeException(nameof(request.Total));
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Enable nullable reference types.
- Use decimal for business money and define rounding.
- Validate untrusted input before creating domain objects.

## Common Mistakes

- Silencing warnings with `!` without proof.
- Representing every identifier as a string.
- Using floating point for exact totals.

## Best Practices

- Prefer immutable request models.
- Use the narrowest scope.
- Name values by business meaning.

## Interview Questions

1. When would you choose a record?
2. What does `string?` communicate?
3. Why use `decimal` for money?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [Control Flow and Method Design →](../beginner/control-flow-and-methods.md)
