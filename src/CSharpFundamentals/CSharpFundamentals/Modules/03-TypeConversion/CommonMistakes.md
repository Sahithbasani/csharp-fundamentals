# Type Conversion and Boundary Parsing — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| casting without range checks | Can create incorrect behavior, hidden cost, or an unstable contract. |
| using current culture accidentally | Can create incorrect behavior, hidden cost, or an unstable contract. |
| catching parse exceptions for normal input | Can create incorrect behavior, hidden cost, or an unstable contract. |
| confusing representation conversion with validation | Can create incorrect behavior, hidden cost, or an unstable contract. |
| unchecked overflow | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
