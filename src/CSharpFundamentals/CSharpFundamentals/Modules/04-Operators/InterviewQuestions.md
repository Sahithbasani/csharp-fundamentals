# Operators and Expression Semantics — Senior Interview Questions

[← Module README](./README.md)

### 1. How does short-circuit evaluation matter?

The right operand is skipped when the result is already known, affecting cost and side effects.

### 2. Why is operator precedence risky?

Correct syntax can encode the wrong business rule; parentheses document intent.

### 3. When are bit flags appropriate?

For independent combinable options with stable binary values.

### 4. How does nullable lifting work?

Many value-type operators extend to nullable operands and usually produce nullable results.

### 5. When should an operator be overloaded?

Only when the behavior is natural, unsurprising, and consistent with equality.

### 6. What is the central design trade-off in Operators and Expression Semantics?

Operators express arithmetic, comparison, logic, bit manipulation, null handling, pattern matching, assignment, and evaluation order.

### 7. What memory behavior should a reviewer understand?

Most operators do not allocate, but overloaded operators and lifted nullable operations can call code or create results with different semantics.

### 8. What performance evidence should be collected?

Short-circuiting can avoid expensive work; repeated property access, hidden overloads, and accidental boxing can affect critical paths.

### 9. Name a representative production use case.

pricing rules.

### 10. What failure pattern deserves immediate review attention?

relying on unclear precedence.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
