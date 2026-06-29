# Data Types and Representation — Senior Interview Questions

[← Module README](./README.md)

### 1. Class, record, or struct?

Choose from identity, equality, copying, mutability, and allocation requirements.

### 2. What happens during boxing?

A value is copied into an object on the managed heap and accessed through a reference.

### 3. Are records immutable?

Not automatically; positional properties are init-only, but referenced members may remain mutable.

### 4. Why can large structs be expensive?

Assignments and calls may copy the entire value unless passed by reference.

### 5. How should database nulls be modeled?

Use explicit nullable contracts and map missing values at the boundary.

### 6. What is the central design trade-off in Data Types and Representation?

C# data types determine representation, identity, equality, copying, nullability, and the operations available to callers.

### 7. What memory behavior should a reviewer understand?

Reference instances are heap allocated and tracked by the GC; value types are stored inline and can be copied or boxed depending on usage.

### 8. What performance evidence should be collected?

Large structs, repeated boxing, string allocation, and inappropriate numeric types can create hidden CPU and memory costs.

### 9. Name a representative production use case.

API contracts.

### 10. What failure pattern deserves immediate review attention?

large mutable structs.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
