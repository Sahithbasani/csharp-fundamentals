# Namespaces, Assemblies, and Dependency Boundaries — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- layered solutions
- bounded contexts
- public API packaging
- adapter isolation

## Performance Implications

Excessive assemblies increase build and startup overhead, while giant assemblies increase coupling. Measure before splitting for performance alone.

## Memory Implications

Namespaces have no runtime allocation cost; assemblies affect loading, metadata, trimming, and deployment composition.

## Common Enterprise Mistakes

- namespace matching folders without ownership
- circular project references
- public types by default
- shared catch-all projects
- aliases hiding design conflicts

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
