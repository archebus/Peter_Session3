namespace pizza;

public class Order {
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime? OrderFulfilled { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = default!;
    public ICollection<OrderDetail> OrderDetails { get; set; } = default!;
}