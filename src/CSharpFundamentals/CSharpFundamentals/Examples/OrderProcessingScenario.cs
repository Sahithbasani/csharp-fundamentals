namespace CSharpFundamentals.Examples;

internal sealed class OrderProcessingService
{
    private const decimal TaxRate = 0.0825m;
    private const decimal ManualReviewThreshold = 1_000m;

    public OrderResult Process(PlaceOrderRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.CustomerId == Guid.Empty)
            throw new ArgumentException("CustomerId is required.", nameof(request));

        if (request.Lines.Count == 0)
            throw new ArgumentException("At least one order line is required.", nameof(request));

        if (request.Lines.Any(line => line.Quantity <= 0 || line.UnitPrice <= 0))
            throw new ArgumentException("Order lines require positive quantity and price.", nameof(request));

        decimal subtotal = request.Lines.Sum(line => line.Quantity * line.UnitPrice);
        decimal tax = decimal.Round(subtotal * TaxRate, 2, MidpointRounding.AwayFromZero);
        decimal total = subtotal + tax;

        return new OrderResult(
            Guid.NewGuid(),
            subtotal,
            tax,
            total,
            total >= ManualReviewThreshold);
    }
}

internal sealed record PlaceOrderRequest(Guid CustomerId, IReadOnlyList<OrderLine> Lines);

internal sealed record OrderLine(string ProductCode, int Quantity, decimal UnitPrice);

internal sealed record OrderResult(
    Guid OrderId,
    decimal Subtotal,
    decimal Tax,
    decimal Total,
    bool RequiresManualReview);
