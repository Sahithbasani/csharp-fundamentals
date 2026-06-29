# 02 — Data Types and Representation

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Variables and State](../01-Variables/README.md) · [Type Conversion and Boundary Parsing →](../03-TypeConversion/README.md)

## Overview

C# data types determine representation, identity, equality, copying, nullability, and the operations available to callers.

## Why This Concept Matters

Backend contracts cross JSON, databases, queues, and process boundaries. A poor representation creates precision loss, accidental identity, and ambiguous missing values.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Value Versus Reference Semantics |
| 2 | Records And Value Equality |
| 3 | Nullable Value Types |
| 4 | Boxing And Unboxing |
| 5 | Numeric Precision |
| 6 | Object Layout And Allocation |

## Memory Considerations

Reference instances are heap allocated and tracked by the GC; value types are stored inline and can be copied or boxed depending on usage.

## Performance Considerations

Large structs, repeated boxing, string allocation, and inappropriate numeric types can create hidden CPU and memory costs.

## Production Use Cases

- API contracts
- money and measurement
- database null mapping
- immutable messages

## Common Mistakes

- large mutable structs
- using `double` for exact money
- assuming records are deeply immutable
- boxing in hot paths
- using null as an undocumented state

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- choose types from domain semantics
- keep structs small and immutable
- enable nullable analysis
- define equality deliberately
- measure layout-sensitive optimizations

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`ValueTypesExample.cs`](./ValueTypesExample.cs)
- [`ReferenceTypesExample.cs`](./ReferenceTypesExample.cs)
- [`NullableTypesExample.cs`](./NullableTypesExample.cs)
- [`BoxingUnboxingExample.cs`](./BoxingUnboxingExample.cs)
- [`MemoryAllocationExample.cs`](./MemoryAllocationExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Variables and State](../01-Variables/README.md) · [Type Conversion and Boundary Parsing →](../03-TypeConversion/README.md)
