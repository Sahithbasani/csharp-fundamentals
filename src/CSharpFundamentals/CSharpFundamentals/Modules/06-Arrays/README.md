# 06 — Arrays, Spans, and Contiguous Memory

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Strings, Text, Culture, and Encoding](../05-Strings/README.md) · [Methods, Contracts, and API Shape →](../07-Methods/README.md)

## Overview

Arrays provide fixed-size contiguous storage. Span and Memory expose slices without requiring copies while preserving different lifetime rules.

## Why This Concept Matters

Serialization, protocol parsing, batching, and numerical work depend on predictable layout and allocation behavior.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Single-Dimensional Arrays |
| 2 | Multidimensional Arrays |
| 3 | Jagged Arrays |
| 4 | Array Apis |
| 5 | Linq Over Arrays |
| 6 | Span<T> |
| 7 | Memory<T> |
| 8 | Bounds And Pooling |

## Memory Considerations

Arrays are heap objects with inline elements; rectangular and jagged layouts differ, while spans are stack-only views and Memory can cross async boundaries.

## Performance Considerations

Contiguous access is cache friendly. Copies, multidimensional indexing, LINQ allocation, and oversized pooling can affect throughput.

## Production Use Cases

- message batching
- binary protocol parsing
- database result buffers
- report matrices

## Common Mistakes

- returning pooled arrays without clearing sensitive data
- using LINQ in hot loops without measurement
- retaining oversized buffers
- using Span across await
- confusing jagged and rectangular layout

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- use arrays for fixed-size data
- prefer spans for synchronous slicing
- use Memory for async-safe slices
- return pooled buffers in finally
- benchmark representation choices

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`SingleDimensionalExample.cs`](./SingleDimensionalExample.cs)
- [`MultiDimensionalExample.cs`](./MultiDimensionalExample.cs)
- [`JaggedArraysExample.cs`](./JaggedArraysExample.cs)
- [`ArrayMethodsExample.cs`](./ArrayMethodsExample.cs)
- [`ArrayLinqExample.cs`](./ArrayLinqExample.cs)
- [`ArrayPerformanceExample.cs`](./ArrayPerformanceExample.cs)
- [`SpanExample.cs`](./SpanExample.cs)
- [`MemoryExample.cs`](./MemoryExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Strings, Text, Culture, and Encoding](../05-Strings/README.md) · [Methods, Contracts, and API Shape →](../07-Methods/README.md)
