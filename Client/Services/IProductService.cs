﻿using MarketApp.Shared;

namespace MarketApp.Client.Services;

public interface IProductService
{
    List<Product>? Products { get; set; }
    Task GetProducts();
    Task<ServiceResponse<Product>> GetProduct(int productId);
}