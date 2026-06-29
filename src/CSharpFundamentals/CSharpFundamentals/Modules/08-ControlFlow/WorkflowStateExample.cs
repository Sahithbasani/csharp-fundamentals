namespace CSharpFundamentals.Modules.ControlFlow;

/// <summary>
/// Demonstrates control flow and business decisions in a backend-oriented scenario.
/// </summary>
public static class WorkflowStateExample
{
    public enum OrderState { Draft, Submitted, Approved }
    public static OrderState Submit(OrderState state) => state == OrderState.Draft ? OrderState.Submitted : throw new InvalidOperationException("Invalid transition.");
}
