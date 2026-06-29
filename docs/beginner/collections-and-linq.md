# Collections and LINQ

[← Curriculum](../README.md) · [Home](../../README.md) · [← Control Flow and Method Design](../beginner/control-flow-and-methods.md) · [Exceptions and Validation →](../beginner/exceptions-and-validation.md)

**Level:** Beginner

## Overview

Collections communicate ordering, uniqueness, lookup, and concurrency; LINQ expresses readable sequence transformations.

## Why It Matters

A poor collection choice or repeated query enumeration can become a latency and allocation problem in an API.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | List, dictionary, and set trade-offs |
| 2 | Deferred execution |
| 3 | Projection and materialization |



## Practical Backend Example

```csharp
public IReadOnlyList<CustomerOrderSummary> Summarize(IEnumerable<Order> orders) =>
    orders
        .Where(order => order.Status == OrderStatus.Completed)
        .GroupBy(order => order.CustomerId)
        .Select(group => new CustomerOrderSummary(
            group.Key, group.Count(), group.Sum(order => order.Total)))
        .OrderByDescending(summary => summary.TotalValue)
        .ToList();
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Materialize at a deliberate boundary.
- Use the correct equality comparer.
- Know whether LINQ runs in memory or through a provider.

## Common Mistakes

- Using a list for repeated key lookup.
- Enumerating an expensive query repeatedly.
- Putting side effects in LINQ operators.

## Best Practices

- Choose collections from access patterns.
- Project only required data.
- Keep pipelines readable.

## Interview Questions

1. What is deferred execution?
2. When is `HashSet<T>` appropriate?
3. Why can EF Core LINQ behave differently?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Control Flow and Method Design](../beginner/control-flow-and-methods.md) · [Exceptions and Validation →](../beginner/exceptions-and-validation.md)
