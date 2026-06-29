# 08 — Control Flow and Business Decisions

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Methods, Contracts, and API Shape](../07-Methods/README.md) · [Exceptions, Resilience, and Failure Semantics →](../09-ExceptionHandling/README.md)

## Overview

Control flow encodes business decisions through guards, branching, loops, pattern matching, and state transitions.

## Why This Concept Matters

Readable decision logic is essential in authorization, payments, claims, and workflow orchestration where subtle ordering changes affect outcomes.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Guard Clauses |
| 2 | Switch Expressions |
| 3 | Loops And Early Exit |
| 4 | Pattern Matching |
| 5 | State Transitions |
| 6 | Short-Circuiting |

## Memory Considerations

Branching itself rarely allocates, but captured iterators, iterator blocks, and async control flow create compiler-generated state objects.

## Performance Considerations

Predictable branches and early exits can reduce work, but readability and correctness dominate except in measured hot loops.

## Production Use Cases

- payment decisions
- claim eligibility
- authorization policy
- retry classification

## Common Mistakes

- deep nesting
- fall-through assumptions
- side effects in conditions
- missing state cases
- infinite retry loops

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- use guards for invalid input
- model states explicitly
- make switches exhaustive
- separate policy from I/O
- test boundary combinations

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`GuardClausesExample.cs`](./GuardClausesExample.cs)
- [`SwitchExpressionExample.cs`](./SwitchExpressionExample.cs)
- [`LoopControlExample.cs`](./LoopControlExample.cs)
- [`WorkflowStateExample.cs`](./WorkflowStateExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Methods, Contracts, and API Shape](../07-Methods/README.md) · [Exceptions, Resilience, and Failure Semantics →](../09-ExceptionHandling/README.md)
