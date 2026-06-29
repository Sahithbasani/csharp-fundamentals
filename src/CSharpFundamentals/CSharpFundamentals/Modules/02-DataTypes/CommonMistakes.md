# Data Types and Representation — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| large mutable structs | Can create incorrect behavior, hidden cost, or an unstable contract. |
| using `double` for exact money | Can create incorrect behavior, hidden cost, or an unstable contract. |
| assuming records are deeply immutable | Can create incorrect behavior, hidden cost, or an unstable contract. |
| boxing in hot paths | Can create incorrect behavior, hidden cost, or an unstable contract. |
| using null as an undocumented state | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
