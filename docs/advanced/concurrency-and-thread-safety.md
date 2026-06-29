# Concurrency and Thread Safety

[← Curriculum](../README.md) · [Home](../../README.md) · [← Memory, Allocation, and Performance](../advanced/memory-and-performance.md) · [Reflection and Metadata →](../advanced/reflection-and-metadata.md)

**Level:** Advanced

## Overview

Concurrency overlaps operations; thread safety preserves shared-state correctness under that overlap.

## Why It Matters

Singletons, caches, counters, and background processors can pass local testing and race under production load.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | Atomic operations and locks |
| 2 | Concurrent collections |
| 3 | Bounded channels and backpressure |



## Practical Backend Example

```csharp
public sealed class NotificationQueue
{
    private readonly Channel<Notification> _channel =
        Channel.CreateBounded<Notification>(new BoundedChannelOptions(500)
        {
            FullMode = BoundedChannelFullMode.Wait,
            SingleReader = true
        });

    public ValueTask EnqueueAsync(Notification item, CancellationToken token) =>
        _channel.Writer.WriteAsync(item, token);
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Bound queues and define overload behavior.
- Never hold a lock across `await`.
- Test shutdown under activity.

## Common Mistakes

- Sharing a normal dictionary across threads.
- Assuming multi-step concurrent operations are atomic.
- Unlimited parallel work.

## Best Practices

- Prefer immutable messages.
- Protect the actual invariant.
- Expose queue depth and latency.

## Interview Questions

1. Why must singletons be thread-safe?
2. What is backpressure?
3. Why not lock across `await`?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Memory, Allocation, and Performance](../advanced/memory-and-performance.md) · [Reflection and Metadata →](../advanced/reflection-and-metadata.md)
