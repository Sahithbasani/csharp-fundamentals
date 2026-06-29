# Object-Oriented Design and SOLID

[← Curriculum](../README.md) · [Home](../../README.md) · [← Exceptions and Validation](../beginner/exceptions-and-validation.md) · [Interfaces and Dependency Injection →](../intermediate/interfaces-and-dependency-injection.md)

**Level:** Intermediate

## Overview

Object-oriented design combines state and behavior while protecting invariants; SOLID is useful where it reduces real change risk.

## Why It Matters

Long-lived enterprise code benefits from cohesive objects and dependency direction that isolates changing infrastructure.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | Encapsulation |
| 2 | Composition over inheritance |
| 3 | Dependency inversion |



## Practical Backend Example

```csharp
public sealed class Order
{
    private readonly List<OrderLine> _lines = [];
    public IReadOnlyCollection<OrderLine> Lines => _lines.AsReadOnly();
    public OrderStatus Status { get; private set; } = OrderStatus.Draft;

    public void AddLine(OrderLine line)
    {
        if (Status != OrderStatus.Draft)
            throw new InvalidOperationException("Only draft orders can be changed.");
        _lines.Add(line ?? throw new ArgumentNullException(nameof(line)));
    }
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Keep invariants with their owning state.
- Use inheritance only for substitutable behavior.
- Abstract meaningful volatility.

## Common Mistakes

- Public setters that permit invalid state.
- Deep inheritance for code reuse.
- One speculative interface per class.

## Best Practices

- Prefer behavior-rich domain objects.
- Keep responsibilities cohesive.
- Evaluate patterns by trade-offs.

## Interview Questions

1. What does encapsulation protect?
2. What violates Liskov substitution?
3. When is an interface unnecessary?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Exceptions and Validation](../beginner/exceptions-and-validation.md) · [Interfaces and Dependency Injection →](../intermediate/interfaces-and-dependency-injection.md)
