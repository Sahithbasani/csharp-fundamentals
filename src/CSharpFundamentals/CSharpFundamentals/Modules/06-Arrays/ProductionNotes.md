# Arrays, Spans, and Contiguous Memory — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- message batching
- binary protocol parsing
- database result buffers
- report matrices

## Performance Implications

Contiguous access is cache friendly. Copies, multidimensional indexing, LINQ allocation, and oversized pooling can affect throughput.

## Memory Implications

Arrays are heap objects with inline elements; rectangular and jagged layouts differ, while spans are stack-only views and Memory can cross async boundaries.

## Common Enterprise Mistakes

- returning pooled arrays without clearing sensitive data
- using LINQ in hot loops without measurement
- retaining oversized buffers
- using Span across await
- confusing jagged and rectangular layout

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
