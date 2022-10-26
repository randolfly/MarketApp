using MarketApp.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MarketApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace MarketApp.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly DataContext _dataContext;

    public ProductController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
    {
        var products = await _dataContext.Products.ToArrayAsync();
        return Ok(products);
    }
}