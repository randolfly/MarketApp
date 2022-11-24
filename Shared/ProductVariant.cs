using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MarketApp.Shared;

public class ProductVariant {
    [JsonIgnore]
    public Product Product { get; set; }

    [Key, Column(Order = 1)]
    public int ProductId { get; set; }

    public ProductType ProductType { get; set; }
    [Key, Column(Order = 2)]
    public int ProductTypeId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal OriginalPrice { get; set; }

}