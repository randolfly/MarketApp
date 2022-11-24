using System.Net.Http.Json;
using MarketApp.Shared;

namespace MarketApp.Client.Services;

public class ProductService : IProductService {
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public event Action ProductsChanged;

    public List<Product>? Products { get; set; }
    public string Message { get; set; } = "Loading Products";

    public async Task GetProducts(string? categoryUrl)
    {
        ServiceResponse<List<Product>>? result;
        if (categoryUrl == null)
            result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
        else
            result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/Product/category/{categoryUrl}");
        Products = result?.Data;
        ProductsChanged.Invoke();
    }

    public async Task<ServiceResponse<Product>> GetProduct(int productId)
    {
        var result =
            await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"/api/Product/{productId}");
        return result;
    }
    public async Task SearchProducts(string searchText)
    {
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>(
            $"api/Product/search/{searchText}");
        if (result != null && result.Data != null)
            Products = result.Data;
        if (Products.Count == 0)
            Message = "No Products Found.";
        ProductsChanged?.Invoke();
    }
    public async Task<List<string>> GetProductsSearchSuggestions(string searchText)
    {
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<string>>>(
            $"api/Product/search-suggestions/{searchText}");
        return result.Data;
    }
}