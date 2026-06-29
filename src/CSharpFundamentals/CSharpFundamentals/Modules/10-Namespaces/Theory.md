# Namespaces, Assemblies, and Dependency Boundaries — Theory

[← Module README](./README.md)

## Conceptual Model

Namespaces organize type names; assemblies and project references enforce deployment and dependency boundaries. Large .NET systems need discoverable ownership and dependency direction. Namespace aesthetics alone cannot prevent architectural coupling.

## Core Semantics

- file-scoped namespaces
- using directives and aliases
- assembly boundaries
- project references
- internal visibility
- dependency direction

## Memory Model

Namespaces have no runtime allocation cost; assemblies affect loading, metadata, trimming, and deployment composition.

## Runtime and Performance

Excessive assemblies increase build and startup overhead, while giant assemblies increase coupling. Measure before splitting for performance alone.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
