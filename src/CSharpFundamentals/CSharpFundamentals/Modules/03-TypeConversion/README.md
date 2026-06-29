# 03 — Type Conversion and Boundary Parsing

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Data Types and Representation](../02-DataTypes/README.md) · [Operators and Expression Semantics →](../04-Operators/README.md)

## Overview

Conversions translate values between representations. Safe code distinguishes guaranteed widening, potentially lossy narrowing, parsing, and semantic mapping.

## Why This Concept Matters

APIs and configuration receive text while domain code expects validated types. Conversion failures must be predictable, observable, and culture-aware.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Implicit Conversions |
| 2 | Explicit Casts |
| 3 | Checked Arithmetic |
| 4 | Parse Versus Tryparse |
| 5 | Convert Behavior |
| 6 | Domain Mapping |

## Memory Considerations

Conversions may allocate when formatting strings or boxing values; numeric casts normally operate without allocation.

## Performance Considerations

Parsing and formatting can dominate hot serialization paths; failed exception-based parsing is more expensive than `TryParse` for expected bad input.

## Production Use Cases

- route and query parsing
- configuration binding
- database projection
- external API mapping

## Common Mistakes

- casting without range checks
- using current culture accidentally
- catching parse exceptions for normal input
- confusing representation conversion with validation
- unchecked overflow

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- use `TryParse` at trust boundaries
- specify culture
- use `checked` for critical arithmetic
- map into domain types after validation
- test edge ranges

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`ImplicitConversionExample.cs`](./ImplicitConversionExample.cs)
- [`ExplicitConversionExample.cs`](./ExplicitConversionExample.cs)
- [`ConvertClassExample.cs`](./ConvertClassExample.cs)
- [`ParseTryParseExample.cs`](./ParseTryParseExample.cs)
- [`CheckedUncheckedExample.cs`](./CheckedUncheckedExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Data Types and Representation](../02-DataTypes/README.md) · [Operators and Expression Semantics →](../04-Operators/README.md)
