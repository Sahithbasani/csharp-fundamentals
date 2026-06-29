# Arrays, Spans, and Contiguous Memory — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| returning pooled arrays without clearing sensitive data | Can create incorrect behavior, hidden cost, or an unstable contract. |
| using LINQ in hot loops without measurement | Can create incorrect behavior, hidden cost, or an unstable contract. |
| retaining oversized buffers | Can create incorrect behavior, hidden cost, or an unstable contract. |
| using Span across await | Can create incorrect behavior, hidden cost, or an unstable contract. |
| confusing jagged and rectangular layout | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
