# 05 — Strings, Text, Culture, and Encoding

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Operators and Expression Semantics](../04-Operators/README.md) · [Arrays, Spans, and Contiguous Memory →](../06-Arrays/README.md)

## Overview

Strings are immutable UTF-16 sequences. Production text handling requires explicit comparison, culture, normalization, formatting, and encoding decisions.

## Why This Concept Matters

Identifiers, user-facing text, logs, protocols, and database values have different semantics; treating them identically causes security and globalization defects.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Immutability |
| 2 | Stringbuilder |
| 3 | Interpolation And Formatting |
| 4 | Ordinal Versus Culture Comparison |
| 5 | Search And Split |
| 6 | Unicode Encoding |
| 7 | Normalization |
| 8 | Allocation |

## Memory Considerations

Every distinct string is a managed object; slicing, concatenation, formatting, and splitting can allocate additional strings or arrays.

## Performance Considerations

Use builders or streaming for repeated composition, spans for temporary parsing, and explicit comparers to avoid expensive or incorrect culture behavior.

## Production Use Cases

- structured logs
- HTTP headers and identifiers
- CSV/report generation
- localized messages

## Common Mistakes

- using case conversion for comparison
- concatenating in loops
- assuming characters equal bytes
- logging secrets
- splitting large payloads unnecessarily

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- use ordinal comparison for machine identifiers
- specify culture for user-facing formatting
- use UTF-8 explicitly at boundaries
- bound logged text
- normalize only when required

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`StringBuilderExample.cs`](./StringBuilderExample.cs)
- [`InterpolationExample.cs`](./InterpolationExample.cs)
- [`FormattingExample.cs`](./FormattingExample.cs)
- [`SearchingExample.cs`](./SearchingExample.cs)
- [`SplittingExample.cs`](./SplittingExample.cs)
- [`StringPerformanceExample.cs`](./StringPerformanceExample.cs)
- [`CultureExample.cs`](./CultureExample.cs)
- [`EncodingExample.cs`](./EncodingExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Operators and Expression Semantics](../04-Operators/README.md) · [Arrays, Spans, and Contiguous Memory →](../06-Arrays/README.md)
