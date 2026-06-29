# 04 — Operators and Expression Semantics

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Type Conversion and Boundary Parsing](../03-TypeConversion/README.md) · [Strings, Text, Culture, and Encoding →](../05-Strings/README.md)

## Overview

Operators express arithmetic, comparison, logic, bit manipulation, null handling, pattern matching, assignment, and evaluation order.

## Why This Concept Matters

Small expression mistakes can alter authorization, financial calculations, feature flags, and null behavior while remaining syntactically valid.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Arithmetic And Assignment |
| 2 | Comparison And Equality |
| 3 | Short-Circuit Logic |
| 4 | Bit Flags |
| 5 | Null Coalescing |
| 6 | Pattern Matching |
| 7 | Precedence |
| 8 | Operator Overloading |

## Memory Considerations

Most operators do not allocate, but overloaded operators and lifted nullable operations can call code or create results with different semantics.

## Performance Considerations

Short-circuiting can avoid expensive work; repeated property access, hidden overloads, and accidental boxing can affect critical paths.

## Production Use Cases

- pricing rules
- permission flags
- validation predicates
- state-machine matching

## Common Mistakes

- relying on unclear precedence
- using bitwise operators for boolean intent
- comparing strings without an explicit comparer
- overflow in arithmetic
- side effects inside expressions

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- use parentheses for business rules
- prefer ordinal string comparison for identifiers
- use enums with `[Flags]` carefully
- keep overloaded operators unsurprising
- use pattern matching for state

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`ArithmeticOperatorsExample.cs`](./ArithmeticOperatorsExample.cs)
- [`AssignmentOperatorsExample.cs`](./AssignmentOperatorsExample.cs)
- [`ComparisonOperatorsExample.cs`](./ComparisonOperatorsExample.cs)
- [`LogicalOperatorsExample.cs`](./LogicalOperatorsExample.cs)
- [`BitwiseOperatorsExample.cs`](./BitwiseOperatorsExample.cs)
- [`NullCoalescingExample.cs`](./NullCoalescingExample.cs)
- [`PatternMatchingExample.cs`](./PatternMatchingExample.cs)
- [`OperatorPrecedenceExample.cs`](./OperatorPrecedenceExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Type Conversion and Boundary Parsing](../03-TypeConversion/README.md) · [Strings, Text, Culture, and Encoding →](../05-Strings/README.md)
