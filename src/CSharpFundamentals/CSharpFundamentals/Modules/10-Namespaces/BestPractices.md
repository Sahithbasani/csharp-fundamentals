# Namespaces, Assemblies, and Dependency Boundaries — Best Practices

[← Module README](./README.md)

## Engineering Checklist

- align namespaces with ownership
- use internal by default
- enforce dependency direction with project references
- avoid shared dumping grounds
- document public APIs

## Code Review Questions

- Is ownership and mutability visible?
- Are null, failure, culture, and cancellation semantics explicit?
- Does the example preserve domain meaning across boundaries?
- Is a claimed optimization supported by measurement?
- Can the behavior be tested without infrastructure?

## Adoption Guidance

Apply these practices incrementally. In legacy systems, first capture current behavior, then improve one boundary while preserving observable results.
