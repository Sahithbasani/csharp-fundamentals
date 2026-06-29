# Control Flow and Method Design

[← Curriculum](../README.md) · [Home](../../README.md) · [← Variables, Types, and Nullability](../beginner/variables-and-types.md) · [Collections and LINQ →](../beginner/collections-and-linq.md)

**Level:** Beginner

## Overview

Control flow should expose business decisions; methods should perform one coherent job with explicit inputs and results.

## Why It Matters

Approval and validation rules change frequently. Deep nesting and hidden side effects make those changes risky.

## Core Concepts

| # | Working principle |
| ---: | --- |
| 1 | Guard clauses |
| 2 | Pattern matching |
| 3 | Result objects for expected outcomes |



## Practical Backend Example

```csharp
public PaymentDecision Evaluate(PaymentRequest request)
{
    ArgumentNullException.ThrowIfNull(request);
    if (request.Amount <= 0) return PaymentDecision.Rejected("Amount must be positive.");

    return request.RiskLevel switch
    {
        RiskLevel.Low => PaymentDecision.Approved(),
        RiskLevel.Medium when request.Amount <= 1_000m => PaymentDecision.Approved(),
        _ => PaymentDecision.RequiresReview()
    };
}
```

The example focuses on one production concern. Supporting domain types are omitted when they do not change the lesson.

## Production Notes

- Keep policy deterministic.
- Return results for expected business outcomes.
- Separate decisions from I/O.

## Common Mistakes

- Methods that validate, persist, log, and notify.
- Unclear boolean parameters.
- Catching every exception.

## Best Practices

- Prefer guard clauses.
- Use exhaustive state handling.
- Name methods by one business intention.

## Interview Questions

1. When is pattern matching clearer?
2. What makes a method testable?
3. When should code return a result instead of throwing?

<details>
<summary>Answering strategy</summary>

State the language rule, give a backend example, explain the trade-off, and describe the production failure caused by misuse.

</details>

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[← Curriculum](../README.md) · [Home](../../README.md) · [← Variables, Types, and Nullability](../beginner/variables-and-types.md) · [Collections and LINQ →](../beginner/collections-and-linq.md)
