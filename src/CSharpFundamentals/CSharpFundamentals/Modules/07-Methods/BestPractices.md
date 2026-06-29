# Methods, Contracts, and API Shape — Best Practices

[← Module README](./README.md)

## Engineering Checklist

- use intention-revealing names
- prefer result types for expected outcomes
- accept cancellation for I/O
- keep side effects explicit
- version public APIs carefully

## Code Review Questions

- Is ownership and mutability visible?
- Are null, failure, culture, and cancellation semantics explicit?
- Does the example preserve domain meaning across boundaries?
- Is a claimed optimization supported by measurement?
- Can the behavior be tested without infrastructure?

## Adoption Guidance

Apply these practices incrementally. In legacy systems, first capture current behavior, then improve one boundary while preserving observable results.
