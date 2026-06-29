# Data Types and Representation — Theory

[← Module README](./README.md)

## Conceptual Model

C# data types determine representation, identity, equality, copying, nullability, and the operations available to callers. Backend contracts cross JSON, databases, queues, and process boundaries. A poor representation creates precision loss, accidental identity, and ambiguous missing values.

## Core Semantics

- value versus reference semantics
- records and value equality
- nullable value types
- boxing and unboxing
- numeric precision
- object layout and allocation

## Memory Model

Reference instances are heap allocated and tracked by the GC; value types are stored inline and can be copied or boxed depending on usage.

## Runtime and Performance

Large structs, repeated boxing, string allocation, and inappropriate numeric types can create hidden CPU and memory costs.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
