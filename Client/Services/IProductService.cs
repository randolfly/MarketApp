﻿using MarketApp.Shared;

namespace MarketApp.Client.Services;

public interface IProductService {
    event Action ProductsChanged;
    List<Product>? Products { get; set; }
    Task GetProducts(string? categoryUrl = null);
    Task<ServiceResponse<Product>> GetProduct(int productId);
}