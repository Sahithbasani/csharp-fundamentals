# Operators and Expression Semantics — Production Notes

[← Module README](./README.md)

## Where It Is Commonly Used

- pricing rules
- permission flags
- validation predicates
- state-machine matching

## Performance Implications

Short-circuiting can avoid expensive work; repeated property access, hidden overloads, and accidental boxing can affect critical paths.

## Memory Implications

Most operators do not allocate, but overloaded operators and lifted nullable operations can call code or create results with different semantics.

## Common Enterprise Mistakes

- relying on unclear precedence
- using bitwise operators for boolean intent
- comparing strings without an explicit comparer
- overflow in arithmetic
- side effects inside expressions

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
