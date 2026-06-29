# Control Flow and Business Decisions — Senior Interview Questions

[← Module README](./README.md)

### 1. Guard clause or nested if?

Guards make invalid paths explicit and keep the main path readable.

### 2. Why use switch expressions?

They make input-to-result mappings concise and can reveal unhandled states.

### 3. What is a state-machine invariant?

A rule that must hold before and after every allowed transition.

### 4. When is early exit harmful?

When excessive exits obscure cleanup or make the lifecycle difficult to reason about.

### 5. How do you test complex decisions?

Use decision tables and cover boundaries, combinations, and unexpected states.

### 6. What is the central design trade-off in Control Flow and Business Decisions?

Control flow encodes business decisions through guards, branching, loops, pattern matching, and state transitions.

### 7. What memory behavior should a reviewer understand?

Branching itself rarely allocates, but captured iterators, iterator blocks, and async control flow create compiler-generated state objects.

### 8. What performance evidence should be collected?

Predictable branches and early exits can reduce work, but readability and correctness dominate except in measured hot loops.

### 9. Name a representative production use case.

payment decisions.

### 10. What failure pattern deserves immediate review attention?

deep nesting.

## Evaluation Standard

A senior answer should explain the language rule, use a production example, identify trade-offs, and describe how the decision would be tested or measured.
