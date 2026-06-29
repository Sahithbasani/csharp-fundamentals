# Exceptions, Resilience, and Failure Semantics — Theory

[← Module README](./README.md)

## Conceptual Model

Exceptions carry failure information and stack context across call boundaries. Robust services distinguish validation, business outcomes, cancellation, transient faults, and defects. Incorrect exception handling hides root causes, retries unsafe operations, leaks sensitive data, and returns misleading HTTP responses.

## Core Semantics

- throwing and propagation
- custom exceptions
- exception filters
- finally and disposal
- cancellation
- retry classification
- Problem Details

## Memory Model

Exceptions allocate objects and capture stack information; repeated exceptions in expected paths create avoidable CPU and GC pressure.

## Runtime and Performance

Do not use exceptions for routine decisions. Preserve stacks, limit retry scope, and measure failure storms that can amplify outages.

## Engineering Decision

Choose the simplest representation that makes ownership, failure, and domain meaning explicit. Optimize only after measuring the real workload and preserve the contract with tests.

## Microsoft References

- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [.NET fundamentals](https://learn.microsoft.com/dotnet/fundamentals/)
