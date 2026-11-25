using MassTransit;
using ProductsAPI.Messages;

namespace ProductsAPI.Consumers;

public class OrderCreatedConsumer : IConsumer<OrderCreatedEvent>
{
    private readonly ProductsAPIContext _context; // remplace par le nom exact de ton DbContext

    public OrderCreatedConsumer(ProductsAPIContext context)
    {
        _context = context;
    }

    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        var msg = context.Message;
        var product = await _context.Product.FindAsync(msg.ProductId); // adapte _context.Products si besoin

        if (product != null)
        {
            product.StockQte -= 1; // adapte selon le nom exact de ta propriété stock
            await _context.SaveChangesAsync();
        }
    }
}