# Exceptions, Resilience, and Failure Semantics — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| catching and ignoring | Can create incorrect behavior, hidden cost, or an unstable contract. |
| `throw ex` stack loss | Can create incorrect behavior, hidden cost, or an unstable contract. |
| retrying non-idempotent work | Can create incorrect behavior, hidden cost, or an unstable contract. |
| logging secrets | Can create incorrect behavior, hidden cost, or an unstable contract. |
| catching cancellation as generic failure | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
