# Variables and State — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| using `var` when the inferred type is unclear | Can create incorrect behavior, hidden cost, or an unstable contract. |
| sharing mutable fields across requests | Can create incorrect behavior, hidden cost, or an unstable contract. |
| using magic values | Can create incorrect behavior, hidden cost, or an unstable contract. |
| capturing loop variables unintentionally | Can create incorrect behavior, hidden cost, or an unstable contract. |
| silencing nullability warnings | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
