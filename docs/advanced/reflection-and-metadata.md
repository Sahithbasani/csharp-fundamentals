# Reflection and Metadata

[← Curriculum](../README.md) · [Home](../../README.md) · [← Concurrency and Thread Safety](../advanced/concurrency-and-thread-safety.md)

**Level:** Advanced

## Overview

Reflection inspects runtime types and metadata for serializers, tooling, discovery, and controlled extensibility.

## Why It Matters

Framework code may discover handlers dynamically, but excessive reflection delays failures and complicates trimming.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | Runtime `Type` metadata |
| 2 | Declarative attributes |
| 3 | Caching reflected members |



## Practical Backend Example

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class HandlesAttribute(string messageType) : Attribute
{
    public string MessageType { get; } = messageType;
}

[Handles("order.created")]
public sealed class OrderCreatedHandler
{
    public Task HandleAsync(OrderCreated message, CancellationToken token) =>
        Task.CompletedTask;
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Validate discovered types at startup.
- Cache repeated lookups.
- Prefer explicit registration when practical.

## Common Mistakes

- Scanning assemblies per request.
- Bypassing encapsulation.
- Depending on fragile string member names.

## Best Practices

- Keep reflection at framework boundaries.
- Fail fast with useful diagnostics.
- Consider trimming and AOT.

## Interview Questions

1. When is reflection justified?
2. What does an attribute do by itself?
3. How can reflection affect AOT?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Concurrency and Thread Safety](../advanced/concurrency-and-thread-safety.md)
