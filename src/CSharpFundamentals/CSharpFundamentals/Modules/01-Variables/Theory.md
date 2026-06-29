# Variables and State — Theory

[← Module README](./README.md)

## Conceptual Model

Variable declarations communicate type, mutability, scope, and ownership. In production code they should make business intent and lifecycle visible. State errors become expensive when values outlive their intended scope, change unexpectedly, or represent several domain meanings with one primitive type.

## Core Semantics

- explicit typing and inference
- constants and readonly state
- local, member, and captured scope
- nullable state
- naming as design
- thread-visible mutable state

## Memory Model

Local value types usually live in stack frames or registers, while referenced objects live on the managed heap; captured locals can be lifted into closure objects.

## Runtime and Performance

Variable access is cheap, but unnecessary allocation, boxing, captured closures, and shared mutable state can increase GC pressure or synchronization cost.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
