# Type Conversion and Boundary Parsing — Best Practices

[← Module README](./README.md)

## Engineering Checklist

- use `TryParse` at trust boundaries
- specify culture
- use `checked` for critical arithmetic
- map into domain types after validation
- test edge ranges

## Code Review Questions

- Is ownership and mutability visible?
- Are null, failure, culture, and cancellation semantics explicit?
- Does the example preserve domain meaning across boundaries?
- Is a claimed optimization supported by measurement?
- Can the behavior be tested without infrastructure?

## Adoption Guidance

Apply these practices incrementally. In legacy systems, first capture current behavior, then improve one boundary while preserving observable results.
