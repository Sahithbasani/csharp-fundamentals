namespace CSharpFundamentals.Modules.Variables;

public static class VariablesExample
{
    public static void Run()
    {
        Guid orderId = Guid.NewGuid();
        string customerEmail = "customer@example.com";
        decimal subtotal = 925.50m;
        decimal taxRate = 0.0825m;
        decimal tax = decimal.Round(subtotal * taxRate, 2, MidpointRounding.AwayFromZero);
        decimal total = subtotal + tax;
        bool requiresManualReview = total >= 1_000m;
        DateTimeOffset createdAt = DateTimeOffset.UtcNow;

        var summary = new OrderSummary(
            orderId,
            customerEmail,
            total,
            requiresManualReview,
            createdAt);

        Console.WriteLine($"Order: {summary.OrderId}");
        Console.WriteLine($"Customer: {summary.CustomerEmail}");
        Console.WriteLine($"Total: {summary.Total:C}");
        Console.WriteLine($"Manual review: {summary.RequiresManualReview}");
        Console.WriteLine($"Created (UTC): {summary.CreatedAt:O}");
    }

    private sealed record OrderSummary(
        Guid OrderId,
        string CustomerEmail,
        decimal Total,
        bool RequiresManualReview,
        DateTimeOffset CreatedAt);
}
