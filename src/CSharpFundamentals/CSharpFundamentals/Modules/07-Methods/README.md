# 07 — Methods, Contracts, and API Shape

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Arrays, Spans, and Contiguous Memory](../06-Arrays/README.md) · [Control Flow and Business Decisions →](../08-ControlFlow/README.md)

## Overview

Methods define behavioral contracts through names, parameters, return types, generic constraints, async behavior, and error semantics.

## Why This Concept Matters

Public method design affects every caller and test. Ambiguous flags, hidden side effects, and unstable exceptions make large systems difficult to evolve.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Parameters And Returns |
| 2 | Overloads |
| 3 | Optional And Named Arguments |
| 4 | Ref And Out |
| 5 | Local Functions |
| 6 | Generic Methods |
| 7 | Async Methods |
| 8 | Pure Functions |

## Memory Considerations

Passing reference types copies a reference; value types copy values unless ref semantics are used. Async methods allocate state machines when they suspend.

## Performance Considerations

Avoid unnecessary async state machines, large value copies, and excessive parameter objects while prioritizing clear contracts over micro-optimization.

## Production Use Cases

- application use cases
- validation functions
- mapping layers
- repository contracts

## Common Mistakes

- boolean flag parameters
- too many parameters
- async methods without cancellation
- returning null without contract
- overload ambiguity

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- use intention-revealing names
- prefer result types for expected outcomes
- accept cancellation for I/O
- keep side effects explicit
- version public APIs carefully

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`MethodContractsExample.cs`](./MethodContractsExample.cs)
- [`ParameterDesignExample.cs`](./ParameterDesignExample.cs)
- [`GenericMethodExample.cs`](./GenericMethodExample.cs)
- [`AsyncMethodExample.cs`](./AsyncMethodExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Arrays, Spans, and Contiguous Memory](../06-Arrays/README.md) · [Control Flow and Business Decisions →](../08-ControlFlow/README.md)
