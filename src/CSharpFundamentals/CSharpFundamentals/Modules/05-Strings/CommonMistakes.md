# Strings, Text, Culture, and Encoding — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| using case conversion for comparison | Can create incorrect behavior, hidden cost, or an unstable contract. |
| concatenating in loops | Can create incorrect behavior, hidden cost, or an unstable contract. |
| assuming characters equal bytes | Can create incorrect behavior, hidden cost, or an unstable contract. |
| logging secrets | Can create incorrect behavior, hidden cost, or an unstable contract. |
| splitting large payloads unnecessarily | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
