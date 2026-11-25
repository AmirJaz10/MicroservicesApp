namespace OrdersAPI.Messages;

public record OrderCreatedEvent(
    int OrderId,
    int ProductId
  
);