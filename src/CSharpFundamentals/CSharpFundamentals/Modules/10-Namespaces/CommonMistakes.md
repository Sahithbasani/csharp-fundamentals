# Namespaces, Assemblies, and Dependency Boundaries — Common Mistakes

[← Module README](./README.md)

| Mistake | Production consequence |
| --- | --- |
| namespace matching folders without ownership | Can create incorrect behavior, hidden cost, or an unstable contract. |
| circular project references | Can create incorrect behavior, hidden cost, or an unstable contract. |
| public types by default | Can create incorrect behavior, hidden cost, or an unstable contract. |
| shared catch-all projects | Can create incorrect behavior, hidden cost, or an unstable contract. |
| aliases hiding design conflicts | Can create incorrect behavior, hidden cost, or an unstable contract. |

## Review Strategy

Reproduce the behavior with a focused test, identify the violated contract, and make the smallest reversible correction. Avoid combining behavioral fixes with unrelated architectural changes.
