# Arrays, Spans, and Contiguous Memory — Best Practices

[← Module README](./README.md)

## Engineering Checklist

- use arrays for fixed-size data
- prefer spans for synchronous slicing
- use Memory for async-safe slices
- return pooled buffers in finally
- benchmark representation choices

## Code Review Questions

- Is ownership and mutability visible?
- Are null, failure, culture, and cancellation semantics explicit?
- Does the example preserve domain meaning across boundaries?
- Is a claimed optimization supported by measurement?
- Can the behavior be tested without infrastructure?

## Adoption Guidance

Apply these practices incrementally. In legacy systems, first capture current behavior, then improve one boundary while preserving observable results.
