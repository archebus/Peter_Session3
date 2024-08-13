using System.ComponentModel.DataAnnotations.Schema;

namespace pizza;

public class Product {
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }
}