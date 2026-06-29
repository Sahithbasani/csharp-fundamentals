# Exceptions, Resilience, and Failure Semantics — Best Practices

[← Module README](./README.md)

## Engineering Checklist

- catch only when adding value
- use `throw;` to preserve context
- map errors at boundaries
- retry only classified transient failures
- test cleanup and cancellation

## Code Review Questions

- Is ownership and mutability visible?
- Are null, failure, culture, and cancellation semantics explicit?
- Does the example preserve domain meaning across boundaries?
- Is a claimed optimization supported by measurement?
- Can the behavior be tested without infrastructure?

## Adoption Guidance

Apply these practices incrementally. In legacy systems, first capture current behavior, then improve one boundary while preserving observable results.
