# Namespaces, Assemblies, and Dependency Boundaries — Senior Interview Questions

[← Module README](./README.md)

### 1. Do namespaces enforce architecture?

No; project and assembly references enforce dependencies, while namespaces mainly organize names.

### 2. What does `internal` protect?

It limits access to the declaring assembly unless explicitly exposed to a friend assembly.

### 3. When should a project be split?

When ownership, deployment, reuse, or dependency boundaries justify the cost.

### 4. What are file-scoped namespaces?

A concise namespace declaration applying to the rest of the file.

### 5. How do circular dependencies arise?

Two components depend on each other's implementation rather than a stable directional contract.

### 6. What is the central design trade-off in Namespaces, Assemblies, and Dependency Boundaries?

Namespaces organize type names; assemblies and project references enforce deployment and dependency boundaries.

### 7. What memory behavior should a reviewer understand?

Namespaces have no runtime allocation cost; assemblies affect loading, metadata, trimming, and deployment composition.

### 8. What performance evidence should be collected?

Excessive assemblies increase build and startup overhead, while giant assemblies increase coupling. Measure before splitting for performance alone.

### 9. Name a representative production use case.

layered solutions.

### 10. What failure pattern deserves immediate review attention?

namespace matching folders without ownership.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
