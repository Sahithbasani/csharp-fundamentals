# Type Conversion and Boundary Parsing — Senior Interview Questions

[← Module README](./README.md)

### 1. When is an implicit conversion safe?

When every source value can be represented without information loss.

### 2. Why prefer `TryParse` for user input?

Invalid input is expected and should not pay exception cost or obscure control flow.

### 3. What does `checked` change?

Integral overflow throws instead of silently wrapping.

### 4. How does `Convert.ToInt32(null)` behave?

It returns zero, which may hide missing data and differs from parsing null.

### 5. Where should semantic mapping occur?

At an application boundary before untrusted representations enter the domain.

### 6. What is the central design trade-off in Type Conversion and Boundary Parsing?

Conversions translate values between representations. Safe code distinguishes guaranteed widening, potentially lossy narrowing, parsing, and semantic mapping.

### 7. What memory behavior should a reviewer understand?

Conversions may allocate when formatting strings or boxing values; numeric casts normally operate without allocation.

### 8. What performance evidence should be collected?

Parsing and formatting can dominate hot serialization paths; failed exception-based parsing is more expensive than `TryParse` for expected bad input.

### 9. Name a representative production use case.

route and query parsing.

### 10. What failure pattern deserves immediate review attention?

casting without range checks.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
