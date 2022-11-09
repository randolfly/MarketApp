using System.Net.Http.Json;
using MarketApp.Shared;

namespace MarketApp.Client.Services;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<Product>? Products { get; set; }
    public Product? SelectedProduct { get; set; }

    public async Task GetProducts()
    {
        var result =
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
        Products = result?.Data;
    }

    public async Task<ServiceResponse<Product>> GetProduct(int productId)
    {
        var result =
            await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"/api/Product/{productId}");
        return result;
    }
}