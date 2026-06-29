# Type Conversion and Boundary Parsing — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- route and query parsing
- configuration binding
- database projection
- external API mapping

## Performance Implications

Parsing and formatting can dominate hot serialization paths; failed exception-based parsing is more expensive than `TryParse` for expected bad input.

## Memory Implications

Conversions may allocate when formatting strings or boxing values; numeric casts normally operate without allocation.

## Common Enterprise Mistakes

- casting without range checks
- using current culture accidentally
- catching parse exceptions for normal input
- confusing representation conversion with validation
- unchecked overflow

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
