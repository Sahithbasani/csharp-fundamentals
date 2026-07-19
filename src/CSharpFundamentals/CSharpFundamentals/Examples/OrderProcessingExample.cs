namespace CSharpFundamentals.Examples;

public sealed class OrderProcessingExample : IBackendExample
{
    private readonly OrderProcessingService _service = new();

    public string Name => "Order processing";

    public string Description =>
        "Validates an order request, calculates totals, and identifies orders requiring review.";

    public Task RunAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var request = new PlaceOrderRequest(
            Guid.Parse("9d779845-06d7-40a8-8844-a3014c84238f"),
            [
                new OrderLine("API-SUPPORT", 2, 375.00m),
                new OrderLine("REPORTING", 1, 225.50m)
            ]);

        OrderResult result = _service.Process(request);

        Console.WriteLine($"Order ID: {result.OrderId}");
        Console.WriteLine($"Subtotal: {result.Subtotal:C}");
        Console.WriteLine($"Tax: {result.Tax:C}");
        Console.WriteLine($"Total: {result.Total:C}");
        Console.WriteLine($"Manual review: {result.RequiresManualReview}");

        return Task.CompletedTask;
    }
}
