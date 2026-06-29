# Operators and Expression Semantics — Theory

[← Module README](./README.md)

## Conceptual Model

Operators express arithmetic, comparison, logic, bit manipulation, null handling, pattern matching, assignment, and evaluation order. Small expression mistakes can alter authorization, financial calculations, feature flags, and null behavior while remaining syntactically valid.

## Core Semantics

- arithmetic and assignment
- comparison and equality
- short-circuit logic
- bit flags
- null coalescing
- pattern matching
- precedence
- operator overloading

## Memory Model

Most operators do not allocate, but overloaded operators and lifted nullable operations can call code or create results with different semantics.

## Runtime and Performance

Short-circuiting can avoid expensive work; repeated property access, hidden overloads, and accidental boxing can affect critical paths.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
