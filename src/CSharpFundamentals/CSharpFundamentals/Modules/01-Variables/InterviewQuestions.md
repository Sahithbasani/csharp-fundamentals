# Variables and State — Senior Interview Questions

[← Module README](./README.md)

### 1. When should `var` be avoided?

When it hides an important type or makes review dependent on navigating elsewhere.

### 2. How do closures affect variable lifetime?

Captured variables are stored in a compiler-generated object and may outlive the declaring stack frame.

### 3. What is the difference between `const` and `readonly`?

`const` is compile-time and implicitly static; `readonly` is assigned at declaration or construction.

### 4. How would you model money safely?

Use `decimal` plus currency and rounding policy rather than a context-free primitive.

### 5. Why are nullable annotations valuable?

They turn missing-value assumptions into compiler-visible contracts.

### 6. What is the central design trade-off in Variables and State?

Variable declarations communicate type, mutability, scope, and ownership. In production code they should make business intent and lifecycle visible.

### 7. What memory behavior should a reviewer understand?

Local value types usually live in stack frames or registers, while referenced objects live on the managed heap; captured locals can be lifted into closure objects.

### 8. What performance evidence should be collected?

Variable access is cheap, but unnecessary allocation, boxing, captured closures, and shared mutable state can increase GC pressure or synchronization cost.

### 9. Name a representative production use case.

request validation.

### 10. What failure pattern deserves immediate review attention?

using `var` when the inferred type is unclear.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
