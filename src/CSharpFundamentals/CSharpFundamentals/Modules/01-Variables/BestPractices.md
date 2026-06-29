# Variables and State — Best Practices

[← Module README](./README.md)

## Engineering Checklist

- prefer the narrowest scope
- use constants for compile-time invariants
- use readonly fields for construction-time state
- name values in domain language
- avoid shared mutable state

## Code Review Questions

- Is ownership and mutability visible?
- Are null, failure, culture, and cancellation semantics explicit?
- Does the example preserve domain meaning across boundaries?
- Is a claimed optimization supported by measurement?
- Can the behavior be tested without infrastructure?

## Adoption Guidance

Apply these practices incrementally. In legacy systems, first capture current behavior, then improve one boundary while preserving observable results.
