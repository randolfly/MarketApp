using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MarketApp.Shared;

namespace MarketApp.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private static List<Product> _products = new()
    {
        new Product()
        {
            Id = 1,
            Title = "A",
            Description = "PDDDD",
            Price = 9.99m,
            ImageUrl = "https://chaoskey.oschina.io/notes/images/0109.jpg"
        },
        new Product()
        {
            Id = 2,
            Title = "B",
            Description = "PDDDD",
            Price = 19.99m,
            ImageUrl = "https://chaoskey.oschina.io/notes/images/0109.jpg"
        },
        new Product()
        {
            Id = 3,
            Title = "C",
            Description = "PDDDD",
            Price = 29.99m,
            ImageUrl = "https://chaoskey.oschina.io/notes/images/0109.jpg"
        }
    };

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
    {
        return Ok(_products);
    }
}