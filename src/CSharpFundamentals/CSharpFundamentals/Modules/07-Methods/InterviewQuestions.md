# Methods, Contracts, and API Shape — Senior Interview Questions

[← Module README](./README.md)

### 1. What makes a method contract stable?

Clear inputs, outputs, side effects, exceptions, nullability, and cancellation behavior.

### 2. When is `ref` appropriate?

For measured copy avoidance or APIs that intentionally mutate caller-owned storage.

### 3. Why avoid boolean flags?

They hide intent at call sites and often combine multiple responsibilities.

### 4. When can `async` be omitted?

When directly returning an existing task without additional await-based control flow.

### 5. How should expected failures be returned?

Use a domain result or discriminated outcome rather than exceptions for normal decisions.

### 6. What is the central design trade-off in Methods, Contracts, and API Shape?

Methods define behavioral contracts through names, parameters, return types, generic constraints, async behavior, and error semantics.

### 7. What memory behavior should a reviewer understand?

Passing reference types copies a reference; value types copy values unless ref semantics are used. Async methods allocate state machines when they suspend.

### 8. What performance evidence should be collected?

Avoid unnecessary async state machines, large value copies, and excessive parameter objects while prioritizing clear contracts over micro-optimization.

### 9. Name a representative production use case.

application use cases.

### 10. What failure pattern deserves immediate review attention?

boolean flag parameters.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
