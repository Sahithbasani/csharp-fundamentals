# Strings, Text, Culture, and Encoding — Theory

[← Module README](./README.md)

## Conceptual Model

Strings are immutable UTF-16 sequences. Production text handling requires explicit comparison, culture, normalization, formatting, and encoding decisions. Identifiers, user-facing text, logs, protocols, and database values have different semantics; treating them identically causes security and globalization defects.

## Core Semantics

- immutability
- StringBuilder
- interpolation and formatting
- ordinal versus culture comparison
- search and split
- Unicode encoding
- normalization
- allocation

## Memory Model

Every distinct string is a managed object; slicing, concatenation, formatting, and splitting can allocate additional strings or arrays.

## Runtime and Performance

Use builders or streaming for repeated composition, spans for temporary parsing, and explicit comparers to avoid expensive or incorrect culture behavior.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
