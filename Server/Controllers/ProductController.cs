using Bogus;
using MarketApp.Server.Data;
using MarketApp.Server.Services.ProductService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MarketApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace MarketApp.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase {
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
    {
        var response = await _productService.GetProductsAsync();
        return Ok(response);
    }

    [HttpGet]
    [Route("{productId}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
    {
        var response = await _productService.GetProductAsync(productId);
        return Ok(response);
    }

    [HttpGet]
    [Route("category/{categoryUrl}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl)
    {
        var response = await _productService.GetProductsByCategory(categoryUrl);
        return Ok(response);
    }

    #region test api and functions

    [HttpGet]
    [Route("/api/random/category/{categoryNum}")]
    public ActionResult<List<Category>> GetRandomCategories(int categoryNum = 5)
    {
        int categoryId = 1;
        var categoryGenerater = new Faker<Category>()
            //Ensure all properties have rules. By default, StrictMode is false
            //Set a global policy by using Faker.DefaultStrictMode
            .StrictMode(true)
            //OrderId is deterministic
            .RuleFor(o => o.Id, f => categoryId++)
            .RuleFor(o => o.Name, f => f.Random.Word())
            .RuleFor(o => o.Url, (f, o) => o.Name.ToLower());
        Console.WriteLine($"ID LENGTH: {categoryId}");
        return Ok(categoryGenerater.Generate(categoryNum));
    }

    [HttpGet]
    [Route("/api/random/product/{productNum}")]
    public ActionResult<List<Product>> GetRandomProducts(int productNum = 5)
    {
        int productId = 1;
        var productGenerater = new Faker<Product>()
            //Ensure all properties have rules. By default, StrictMode is false
            //Set a global policy by using Faker.DefaultStrictMode
            .StrictMode(false)
            //OrderId is deterministic
            .RuleFor(o => o.Id, f => productId++)
            .RuleFor(o => o.Title, f => f.Random.Word())
            .RuleFor(o => o.Description, f => f.Random.Words(10))
            .RuleFor(o => o.ImageUrl, f => f.Image.PicsumUrl())
            .RuleFor(o => o.CategoryId, f => f.Random.Number(min: 1, max: 100))
            .RuleFor(o => o.Price, f => f.Random.Decimal());
        Console.WriteLine($"ID LENGTH: {productId}");
        var randomProducts = productGenerater.Generate(productNum);
        randomProducts.Sort((x, y) => x.Id - y.Id);
        return Ok(randomProducts);
    }

    #endregion
}