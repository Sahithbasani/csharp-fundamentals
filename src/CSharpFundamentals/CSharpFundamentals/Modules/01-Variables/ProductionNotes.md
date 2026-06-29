# Variables and State — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- request validation
- order totals and thresholds
- configuration snapshots
- correlation identifiers

## Performance Implications

Variable access is cheap, but unnecessary allocation, boxing, captured closures, and shared mutable state can increase GC pressure or synchronization cost.

## Memory Implications

Local value types usually live in stack frames or registers, while referenced objects live on the managed heap; captured locals can be lifted into closure objects.

## Common Enterprise Mistakes

- using `var` when the inferred type is unclear
- sharing mutable fields across requests
- using magic values
- capturing loop variables unintentionally
- silencing nullability warnings

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
