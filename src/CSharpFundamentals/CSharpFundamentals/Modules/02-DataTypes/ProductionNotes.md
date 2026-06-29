# Data Types and Representation — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- API contracts
- money and measurement
- database null mapping
- immutable messages

## Performance Implications

Large structs, repeated boxing, string allocation, and inappropriate numeric types can create hidden CPU and memory costs.

## Memory Implications

Reference instances are heap allocated and tracked by the GC; value types are stored inline and can be copied or boxed depending on usage.

## Common Enterprise Mistakes

- large mutable structs
- using `double` for exact money
- assuming records are deeply immutable
- boxing in hot paths
- using null as an undocumented state

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
