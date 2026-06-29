# Methods, Contracts, and API Shape — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- application use cases
- validation functions
- mapping layers
- repository contracts

## Performance Implications

Avoid unnecessary async state machines, large value copies, and excessive parameter objects while prioritizing clear contracts over micro-optimization.

## Memory Implications

Passing reference types copies a reference; value types copy values unless ref semantics are used. Async methods allocate state machines when they suspend.

## Common Enterprise Mistakes

- boolean flag parameters
- too many parameters
- async methods without cancellation
- returning null without contract
- overload ambiguity

## Use in Large .NET Applications

Large systems use this feature behind explicit application, domain, and infrastructure boundaries. Teams standardize contracts, add analyzers and tests, and observe runtime behavior before broad adoption.

## Microsoft-Aligned Recommendations

- Enable nullable reference analysis and current analyzers.
- Prefer explicit, readable contracts over clever syntax.
- Measure allocation and throughput with representative workloads.
- Follow the current C# language reference for version-specific behavior.
- Preserve backward compatibility for public APIs and serialized contracts.

## References

- [C# programming guide](https://learn.microsoft.com/dotnet/csharp/programming-guide/)
- [.NET performance guidance](https://learn.microsoft.com/dotnet/core/deploying/ready-to-run)
