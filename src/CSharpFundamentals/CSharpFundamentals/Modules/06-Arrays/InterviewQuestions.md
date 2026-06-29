# Arrays, Spans, and Contiguous Memory — Senior Interview Questions

[← Module README](./README.md)

### 1. Array or List?

Use arrays for fixed size and compact indexed access; List for dynamic growth.

### 2. Why is Span stack-only?

It may reference stack memory and therefore cannot escape to the heap.

### 3. Jagged or rectangular array?

Jagged arrays allow uneven rows and often simpler iteration; rectangular arrays provide one object and fixed dimensions.

### 4. When should ArrayPool be used?

For measured high-frequency temporary buffers with disciplined return and clearing.

### 5. Can Memory<T> cross await?

Yes; unlike Span<T>, it is heap-safe and can be stored or used across async boundaries.

### 6. What is the central design trade-off in Arrays, Spans, and Contiguous Memory?

Arrays provide fixed-size contiguous storage. Span and Memory expose slices without requiring copies while preserving different lifetime rules.

### 7. What memory behavior should a reviewer understand?

Arrays are heap objects with inline elements; rectangular and jagged layouts differ, while spans are stack-only views and Memory can cross async boundaries.

### 8. What performance evidence should be collected?

Contiguous access is cache friendly. Copies, multidimensional indexing, LINQ allocation, and oversized pooling can affect throughput.

### 9. Name a representative production use case.

message batching.

### 10. What failure pattern deserves immediate review attention?

returning pooled arrays without clearing sensitive data.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
