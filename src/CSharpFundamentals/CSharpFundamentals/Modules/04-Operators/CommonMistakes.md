# Operators and Expression Semantics — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| relying on unclear precedence | Can create incorrect behavior, hidden cost, or an unstable contract. |
| using bitwise operators for boolean intent | Can create incorrect behavior, hidden cost, or an unstable contract. |
| comparing strings without an explicit comparer | Can create incorrect behavior, hidden cost, or an unstable contract. |
| overflow in arithmetic | Can create incorrect behavior, hidden cost, or an unstable contract. |
| side effects inside expressions | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
