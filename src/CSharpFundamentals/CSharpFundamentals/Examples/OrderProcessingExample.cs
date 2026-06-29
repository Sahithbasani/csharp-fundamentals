namespace CSharpFundamentals.Examples;

public sealed class OrderProcessingExample : IBackendExample
{
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

        OrderResult result = Process(request);

        Console.WriteLine($"Order ID: {result.OrderId}");
        Console.WriteLine($"Subtotal: {result.Subtotal:C}");
        Console.WriteLine($"Tax: {result.Tax:C}");
        Console.WriteLine($"Total: {result.Total:C}");
        Console.WriteLine($"Manual review: {result.RequiresManualReview}");

        return Task.CompletedTask;
    }

    private static OrderResult Process(PlaceOrderRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.CustomerId == Guid.Empty)
            throw new ArgumentException("CustomerId is required.", nameof(request));

        if (request.Lines.Count == 0)
            throw new ArgumentException("At least one order line is required.", nameof(request));

        if (request.Lines.Any(line => line.Quantity <= 0 || line.UnitPrice <= 0))
            throw new ArgumentException("Order lines require positive quantity and price.", nameof(request));

        decimal subtotal = request.Lines.Sum(line => line.Quantity * line.UnitPrice);
        decimal tax = decimal.Round(subtotal * 0.0825m, 2, MidpointRounding.AwayFromZero);
        decimal total = subtotal + tax;

        return new OrderResult(
            Guid.NewGuid(),
            subtotal,
            tax,
            total,
            total >= 1_000m);
    }

    private sealed record PlaceOrderRequest(Guid CustomerId, IReadOnlyList<OrderLine> Lines);

    private sealed record OrderLine(string ProductCode, int Quantity, decimal UnitPrice);

    private sealed record OrderResult(
        Guid OrderId,
        decimal Subtotal,
        decimal Tax,
        decimal Total,
        bool RequiresManualReview);
}
