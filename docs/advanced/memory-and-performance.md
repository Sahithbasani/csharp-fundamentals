# Memory, Allocation, and Performance

[← Curriculum](../README.md) · [Home](../../README.md) · [← Delegates, Events, and Pipelines](../advanced/delegates-events-pipelines.md) · [Concurrency and Thread Safety →](../advanced/concurrency-and-thread-safety.md)

**Level:** Advanced

## Overview

Managed memory removes manual deallocation, not resource ownership or performance cost.

## Why It Matters

Allocation rate, retained caches, boxing, and large buffers can affect latency and capacity in high-throughput services.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | Generational garbage collection |
| 2 | Deterministic disposal |
| 3 | Streaming versus buffering |



## Practical Backend Example

```csharp
public async Task ExportAsync(
    Stream destination,
    IAsyncEnumerable<ReportRow> rows,
    CancellationToken token)
{
    await using var writer = new StreamWriter(destination, leaveOpen: true);
    await foreach (var row in rows.WithCancellation(token))
        await writer.WriteLineAsync($"{row.Id},{row.Total}");
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Profile before optimizing.
- Stream large results.
- Dispose owned external resources.

## Common Mistakes

- Calling `GC.Collect()` routinely.
- Assuming GC closes handles promptly.
- Using unbounded caches.

## Best Practices

- Use pooling only with evidence.
- Avoid accidental boxing on hot paths.
- Define cache limits.

## Interview Questions

1. When is an object collectible?
2. Why does `IDisposable` matter?
3. When can structs hurt performance?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Delegates, Events, and Pipelines](../advanced/delegates-events-pipelines.md) · [Concurrency and Thread Safety →](../advanced/concurrency-and-thread-safety.md)
