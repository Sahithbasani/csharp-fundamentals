# Strings, Text, Culture, and Encoding — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- structured logs
- HTTP headers and identifiers
- CSV/report generation
- localized messages

## Performance Implications

Use builders or streaming for repeated composition, spans for temporary parsing, and explicit comparers to avoid expensive or incorrect culture behavior.

## Memory Implications

Every distinct string is a managed object; slicing, concatenation, formatting, and splitting can allocate additional strings or arrays.

## Common Enterprise Mistakes

- using case conversion for comparison
- concatenating in loops
- assuming characters equal bytes
- logging secrets
- splitting large payloads unnecessarily

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
