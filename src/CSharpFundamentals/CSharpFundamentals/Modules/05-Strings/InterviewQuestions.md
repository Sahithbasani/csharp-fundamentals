# Strings, Text, Culture, and Encoding — Senior Interview Questions

[← Module README](./README.md)

### 1. Why are strings immutable?

Immutability enables safe sharing, stable hashing, and simpler concurrency at the cost of new allocations for changes.

### 2. Ordinal or culture comparison?

Ordinal for protocol and identifiers; culture-aware comparison for user-facing linguistic text.

### 3. When is StringBuilder useful?

For repeated, unknown-count mutations where intermediate strings would otherwise allocate.

### 4. What does UTF-8 encoding do?

It converts .NET UTF-16 text into a variable-width byte representation.

### 5. Why is `ToLower()` comparison unsafe?

It allocates and can produce culture-sensitive results that do not match identifier rules.

### 6. What is the central design trade-off in Strings, Text, Culture, and Encoding?

Strings are immutable UTF-16 sequences. Production text handling requires explicit comparison, culture, normalization, formatting, and encoding decisions.

### 7. What memory behavior should a reviewer understand?

Every distinct string is a managed object; slicing, concatenation, formatting, and splitting can allocate additional strings or arrays.

### 8. What performance evidence should be collected?

Use builders or streaming for repeated composition, spans for temporary parsing, and explicit comparers to avoid expensive or incorrect culture behavior.

### 9. Name a representative production use case.

structured logs.

### 10. What failure pattern deserves immediate review attention?

using case conversion for comparison.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
