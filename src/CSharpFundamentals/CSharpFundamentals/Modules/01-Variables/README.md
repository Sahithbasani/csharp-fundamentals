# 01 — Variables and State

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [Data Types and Representation →](../02-DataTypes/README.md)

## Overview

Variable declarations communicate type, mutability, scope, and ownership. In production code they should make business intent and lifecycle visible.

## Why This Concept Matters

State errors become expensive when values outlive their intended scope, change unexpectedly, or represent several domain meanings with one primitive type.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Explicit Typing And Inference |
| 2 | Constants And Readonly State |
| 3 | Local, Member, And Captured Scope |
| 4 | Nullable State |
| 5 | Naming As Design |
| 6 | Thread-Visible Mutable State |

## Memory Considerations

Local value types usually live in stack frames or registers, while referenced objects live on the managed heap; captured locals can be lifted into closure objects.

## Performance Considerations

Variable access is cheap, but unnecessary allocation, boxing, captured closures, and shared mutable state can increase GC pressure or synchronization cost.

## Production Use Cases

- request validation
- order totals and thresholds
- configuration snapshots
- correlation identifiers

## Common Mistakes

- using `var` when the inferred type is unclear
- sharing mutable fields across requests
- using magic values
- capturing loop variables unintentionally
- silencing nullability warnings

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- prefer the narrowest scope
- use constants for compile-time invariants
- use readonly fields for construction-time state
- name values in domain language
- avoid shared mutable state

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`VariableExamples.cs`](./VariableExamples.cs)
- [`ConstantsExample.cs`](./ConstantsExample.cs)
- [`ScopeExample.cs`](./ScopeExample.cs)
- [`NamingConventionExamples.cs`](./NamingConventionExamples.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [Data Types and Representation →](../02-DataTypes/README.md)
