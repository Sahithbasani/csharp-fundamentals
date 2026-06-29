# Methods, Contracts, and API Shape — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| boolean flag parameters | Can create incorrect behavior, hidden cost, or an unstable contract. |
| too many parameters | Can create incorrect behavior, hidden cost, or an unstable contract. |
| async methods without cancellation | Can create incorrect behavior, hidden cost, or an unstable contract. |
| returning null without contract | Can create incorrect behavior, hidden cost, or an unstable contract. |
| overload ambiguity | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
