# Exceptions, Resilience, and Failure Semantics — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- API error mapping
- database transient handling
- background worker supervision
- resource cleanup

## Performance Implications

Do not use exceptions for routine decisions. Preserve stacks, limit retry scope, and measure failure storms that can amplify outages.

## Memory Implications

Exceptions allocate objects and capture stack information; repeated exceptions in expected paths create avoidable CPU and GC pressure.

## Common Enterprise Mistakes

- catching and ignoring
- `throw ex` stack loss
- retrying non-idempotent work
- logging secrets
- catching cancellation as generic failure

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
