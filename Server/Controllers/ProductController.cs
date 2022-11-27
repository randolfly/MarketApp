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

    [HttpGet]
    [Route("search/{searchText}/{page}")]
    public async Task<ActionResult<ServiceResponse<ProductSearchResult>>> SearchProducts(string searchText, int page)
    {
        var response = await _productService.SearchProducts(searchText, page);
        return Ok(response);
    }

    [HttpGet]
    [Route("search-suggestions/{searchText}")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetProductSearchSuggestions(string searchText)
    {
        var response = await _productService.GetProductSearchSuggestions(searchText);
        return Ok(response);
    }

    [HttpGet]
    [Route("featured")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetFeaturedProducts()
    {
        var response = await _productService.GetFeaturedProducts();
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

    #endregion
}