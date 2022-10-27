﻿using MarketApp.Server.Data;
using MarketApp.Server.Services.ProductService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MarketApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace MarketApp.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<IEnumerable<Product>>>> GetProduct()
    {
        var response = await _productService.GetProductAsync();
        return Ok(response);
    }
}