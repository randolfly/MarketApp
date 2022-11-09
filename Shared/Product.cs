using System.ComponentModel.DataAnnotations.Schema;

namespace MarketApp.Shared;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = String.Empty;
    [Column(TypeName = "decimal(18,2)")] public decimal Price { get; set; }

    public Category? Category { get; set; }
    public int CategoryId { get; set; }
}