# 09 — Exceptions, Resilience, and Failure Semantics

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Control Flow and Business Decisions](../08-ControlFlow/README.md) · [Namespaces, Assemblies, and Dependency Boundaries →](../10-Namespaces/README.md)

## Overview

Exceptions carry failure information and stack context across call boundaries. Robust services distinguish validation, business outcomes, cancellation, transient faults, and defects.

## Why This Concept Matters

Incorrect exception handling hides root causes, retries unsafe operations, leaks sensitive data, and returns misleading HTTP responses.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | Throwing And Propagation |
| 2 | Custom Exceptions |
| 3 | Exception Filters |
| 4 | Finally And Disposal |
| 5 | Cancellation |
| 6 | Retry Classification |
| 7 | Problem Details |

## Memory Considerations

Exceptions allocate objects and capture stack information; repeated exceptions in expected paths create avoidable CPU and GC pressure.

## Performance Considerations

Do not use exceptions for routine decisions. Preserve stacks, limit retry scope, and measure failure storms that can amplify outages.

## Production Use Cases

- API error mapping
- database transient handling
- background worker supervision
- resource cleanup

## Common Mistakes

- catching and ignoring
- `throw ex` stack loss
- retrying non-idempotent work
- logging secrets
- catching cancellation as generic failure

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- catch only when adding value
- use `throw;` to preserve context
- map errors at boundaries
- retry only classified transient failures
- test cleanup and cancellation

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`ExceptionPropagationExample.cs`](./ExceptionPropagationExample.cs)
- [`CustomExceptionExample.cs`](./CustomExceptionExample.cs)
- [`ExceptionFilterExample.cs`](./ExceptionFilterExample.cs)
- [`ResilientOperationExample.cs`](./ResilientOperationExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Control Flow and Business Decisions](../08-ControlFlow/README.md) · [Namespaces, Assemblies, and Dependency Boundaries →](../10-Namespaces/README.md)
