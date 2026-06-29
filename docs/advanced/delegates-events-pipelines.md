# Delegates, Events, and Pipelines

[← Curriculum](../README.md) · [Home](../../README.md) · [← Generics and Repository Boundaries](../intermediate/generics-and-repositories.md) · [Memory, Allocation, and Performance →](../advanced/memory-and-performance.md)

**Level:** Advanced

## Overview

Delegates represent typed behavior; events control publication; pipelines compose ordered processing steps.

## Why It Matters

Validation, enrichment, and notification workflows need extensibility with explicit ordering and failure behavior.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | `Func` and `Action` callbacks |
| 2 | Publisher-controlled events |
| 3 | Composable processing stages |



## Practical Backend Example

```csharp
public delegate Task<ClaimContext> ClaimStep(
    ClaimContext context,
    CancellationToken cancellationToken);

public sealed class ClaimPipeline(IEnumerable<ClaimStep> steps)
{
    public async Task<ClaimContext> ExecuteAsync(ClaimContext context, CancellationToken token)
    {
        foreach (var step in steps) context = await step(context, token);
        return context;
    }
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Document stage ordering.
- Use immutable event payloads.
- Unsubscribe short-lived consumers.

## Common Mistakes

- Using events for request-response.
- Ignoring handler exceptions.
- Unexpected lambda captures.

## Best Practices

- Prefer interfaces when steps need dependencies.
- Keep handlers fast.
- Test partial failure.

## Interview Questions

1. How does an event differ from a delegate?
2. What does a closure capture?
3. How do you observe a pipeline?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Generics and Repository Boundaries](../intermediate/generics-and-repositories.md) · [Memory, Allocation, and Performance →](../advanced/memory-and-performance.md)
