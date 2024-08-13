using Microsoft.EntityFrameworkCore;

namespace pizza;

public class PizzaContext : DbContext {

    public DbSet<Customer> Customers { get; set; } = default!;
    public DbSet<Order> Orders { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = default!;

    // Apparantly bad practice to store connection strings un-encryped.
    // You should use a secure storage method for these strings in real-world-apps.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(@"Server=localhost;Database=Pizza;User=user;Password=J@9&kz3*P6!wR^7q;");
    }

}