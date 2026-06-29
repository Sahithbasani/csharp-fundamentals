# Type Conversion and Boundary Parsing — Theory

[← Module README](./README.md)

## Conceptual Model

Conversions translate values between representations. Safe code distinguishes guaranteed widening, potentially lossy narrowing, parsing, and semantic mapping. APIs and configuration receive text while domain code expects validated types. Conversion failures must be predictable, observable, and culture-aware.

## Core Semantics

- implicit conversions
- explicit casts
- checked arithmetic
- parse versus TryParse
- Convert behavior
- domain mapping

## Memory Model

Conversions may allocate when formatting strings or boxing values; numeric casts normally operate without allocation.

## Runtime and Performance

Parsing and formatting can dominate hot serialization paths; failed exception-based parsing is more expensive than `TryParse` for expected bad input.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
