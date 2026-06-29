# Control Flow and Business Decisions — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| deep nesting | Can create incorrect behavior, hidden cost, or an unstable contract. |
| fall-through assumptions | Can create incorrect behavior, hidden cost, or an unstable contract. |
| side effects in conditions | Can create incorrect behavior, hidden cost, or an unstable contract. |
| missing state cases | Can create incorrect behavior, hidden cost, or an unstable contract. |
| infinite retry loops | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
