# Generics and Repository Boundaries

[← Curriculum](../README.md) · [Home](../../README.md) · [← Async/Await and Cancellation](../intermediate/async-await.md) · [Delegates, Events, and Pipelines →](../advanced/delegates-events-pipelines.md)

**Level:** Intermediate

## Overview

Generics enable reuse without losing compile-time types; repositories are useful when they express domain persistence needs.

## Why It Matters

Backend code needs reuse without erasing business meaning or hiding useful database capabilities.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | Type parameters and constraints |
| 2 | Variance |
| 3 | Aggregate-focused repositories |



## Practical Backend Example

```csharp
public interface IEntity<TId> where TId : notnull
{
    TId Id { get; }
}

public interface IOrderRepository
{
    Task<Order?> GetForUpdateAsync(Guid id, CancellationToken token);
    Task AddAsync(Order order, CancellationToken token);
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Use the weakest useful constraint.
- Keep `IQueryable` inside persistence.
- Use dedicated read projections.

## Common Mistakes

- Universal `IRepository<T>` CRUD.
- Partially loaded aggregates.
- Generalizing a one-off operation.

## Best Practices

- Prefer domain names.
- Keep generic APIs small.
- Separate write aggregates from reporting queries.

## Interview Questions

1. What do constraints provide?
2. Why can generic repositories harm EF Core?
3. What is covariance?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Async/Await and Cancellation](../intermediate/async-await.md) · [Delegates, Events, and Pipelines →](../advanced/delegates-events-pipelines.md)
