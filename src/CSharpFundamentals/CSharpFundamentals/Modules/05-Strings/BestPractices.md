# Strings, Text, Culture, and Encoding — Best Practices

[← Module README](./README.md)

## Engineering Checklist

- use ordinal comparison for machine identifiers
- specify culture for user-facing formatting
- use UTF-8 explicitly at boundaries
- bound logged text
- normalize only when required

## Code Review Questions

- Is ownership and mutability visible?
- Are null, failure, culture, and cancellation semantics explicit?
- Does the example preserve domain meaning across boundaries?
- Is a claimed optimization supported by measurement?
- Can the behavior be tested without infrastructure?

## Adoption Guidance

Apply these practices incrementally. In legacy systems, first capture current behavior, then improve one boundary while preserving observable results.
