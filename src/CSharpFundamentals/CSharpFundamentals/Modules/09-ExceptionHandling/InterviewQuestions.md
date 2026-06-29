# Exceptions, Resilience, and Failure Semantics — Senior Interview Questions

[← Module README](./README.md)

### 1. Why is `throw;` different from `throw ex;`?

`throw;` preserves the original stack; `throw ex;` resets the throw location.

### 2. When should a custom exception exist?

When callers need a stable, meaningful failure category with useful context.

### 3. How should cancellation be handled?

Usually allow OperationCanceledException to propagate to the owning boundary.

### 4. What makes a retry safe?

A transient classification, bounded policy, idempotency, and observable attempts.

### 5. Where should HTTP errors be mapped?

At the transport boundary, keeping domain and application layers transport-independent.

### 6. What is the central design trade-off in Exceptions, Resilience, and Failure Semantics?

Exceptions carry failure information and stack context across call boundaries. Robust services distinguish validation, business outcomes, cancellation, transient faults, and defects.

### 7. What memory behavior should a reviewer understand?

Exceptions allocate objects and capture stack information; repeated exceptions in expected paths create avoidable CPU and GC pressure.

### 8. What performance evidence should be collected?

Do not use exceptions for routine decisions. Preserve stacks, limit retry scope, and measure failure storms that can amplify outages.

### 9. Name a representative production use case.

API error mapping.

### 10. What failure pattern deserves immediate review attention?

catching and ignoring.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
