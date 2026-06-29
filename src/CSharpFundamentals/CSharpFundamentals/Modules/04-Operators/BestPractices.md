# Operators and Expression Semantics — Best Practices

[← Module README](./README.md)

## Engineering Checklist

- use parentheses for business rules
- prefer ordinal string comparison for identifiers
- use enums with `[Flags]` carefully
- keep overloaded operators unsurprising
- use pattern matching for state

## Code Review Questions

- Is ownership and mutability visible?
- Are null, failure, culture, and cancellation semantics explicit?
- Does the example preserve domain meaning across boundaries?
- Is a claimed optimization supported by measurement?
- Can the behavior be tested without infrastructure?

## Adoption Guidance

Apply these practices incrementally. In legacy systems, first capture current behavior, then improve one boundary while preserving observable results.
