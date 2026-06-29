# 10 — Namespaces, Assemblies, and Dependency Boundaries

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Exceptions, Resilience, and Failure Semantics](../09-ExceptionHandling/README.md)

## Overview

Namespaces organize type names; assemblies and project references enforce deployment and dependency boundaries.

## Why This Concept Matters

Large .NET systems need discoverable ownership and dependency direction. Namespace aesthetics alone cannot prevent architectural coupling.

## Core Concepts

| # | Concept |
| ---: | --- |
| 1 | File-Scoped Namespaces |
| 2 | Using Directives And Aliases |
| 3 | Assembly Boundaries |
| 4 | Project References |
| 5 | Internal Visibility |
| 6 | Dependency Direction |

## Memory Considerations

Namespaces have no runtime allocation cost; assemblies affect loading, metadata, trimming, and deployment composition.

## Performance Considerations

Excessive assemblies increase build and startup overhead, while giant assemblies increase coupling. Measure before splitting for performance alone.

## Production Use Cases

- layered solutions
- bounded contexts
- public API packaging
- adapter isolation

## Common Mistakes

- namespace matching folders without ownership
- circular project references
- public types by default
- shared catch-all projects
- aliases hiding design conflicts

See [CommonMistakes.md](./CommonMistakes.md) for failure analysis.

## Best Practices

- align namespaces with ownership
- use internal by default
- enforce dependency direction with project references
- avoid shared dumping grounds
- document public APIs

See [BestPractices.md](./BestPractices.md) for review guidance.

## Interview Questions

Ten senior-level questions with concise answers are maintained in [InterviewQuestions.md](./InterviewQuestions.md).

## Code Examples

- [`FileScopedNamespaceExample.cs`](./FileScopedNamespaceExample.cs)
- [`NamespaceAliasExample.cs`](./NamespaceAliasExample.cs)
- [`InternalVisibilityExample.cs`](./InternalVisibilityExample.cs)
- [`DependencyBoundaryExample.cs`](./DependencyBoundaryExample.cs)

## Supporting Notes

- [Theory](./Theory.md)
- [Production notes](./ProductionNotes.md)

## References

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET API browser](https://learn.microsoft.com/dotnet/api/)

---

[Repository home](../../../../../README.md) · [Module index](../../../../../README.md#module-index) · [← Exceptions, Resilience, and Failure Semantics](../09-ExceptionHandling/README.md)
