# Methods, Contracts, and API Shape — Theory

[← Module README](./README.md)

## Conceptual Model

Methods define behavioral contracts through names, parameters, return types, generic constraints, async behavior, and error semantics. Public method design affects every caller and test. Ambiguous flags, hidden side effects, and unstable exceptions make large systems difficult to evolve.

## Core Semantics

- parameters and returns
- overloads
- optional and named arguments
- ref and out
- local functions
- generic methods
- async methods
- pure functions

## Memory Model

Passing reference types copies a reference; value types copy values unless ref semantics are used. Async methods allocate state machines when they suspend.

## Runtime and Performance

Avoid unnecessary async state machines, large value copies, and excessive parameter objects while prioritizing clear contracts over micro-optimization.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
