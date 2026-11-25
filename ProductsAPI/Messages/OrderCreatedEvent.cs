namespace ProductsAPI.Messages
{
    public record OrderCreatedEvent(
     int OrderId,
     int ProductId,
     int Quantity
 );
}
