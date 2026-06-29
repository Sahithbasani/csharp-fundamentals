# Arrays, Spans, and Contiguous Memory — Theory

[← Module README](./README.md)

## Conceptual Model

Arrays provide fixed-size contiguous storage. Span and Memory expose slices without requiring copies while preserving different lifetime rules. Serialization, protocol parsing, batching, and numerical work depend on predictable layout and allocation behavior.

## Core Semantics

- single-dimensional arrays
- multidimensional arrays
- jagged arrays
- Array APIs
- LINQ over arrays
- Span<T>
- Memory<T>
- bounds and pooling

## Memory Model

Arrays are heap objects with inline elements; rectangular and jagged layouts differ, while spans are stack-only views and Memory can cross async boundaries.

## Runtime and Performance

Contiguous access is cache friendly. Copies, multidimensional indexing, LINQ allocation, and oversized pooling can affect throughput.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
