using MarketApp.Server.Data;
using MarketApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace MarketApp.Server.Services.ProductService;

public class ProductService : IProductService {
    private readonly DataContext _dataContext;

    public ProductService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
    {
        var response = new ServiceResponse<List<Product>>()
        {
            Data = await _dataContext.Products
                .Include(p => p.ProductVariants)
                .ToListAsync()
        };
        return response;
    }

    public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
    {
        var response = new ServiceResponse<Product>();
        var product = await _dataContext.Products
            .Include(p => p.ProductVariants)
            .ThenInclude(v => v.ProductType)
            .FirstOrDefaultAsync(p => p.Id == productId);
        if (product == null)
        {
            response.Success = false;
            response.Message = "Sorry, product not exists.";
        }
        else
        {
            response.Data = product;
            response.Success = true;
        }
        return response;
    }
    public async Task<ServiceResponse<List<Product>?>> GetProductsByCategory(string categoryUrl)
    {
        var response = new ServiceResponse<List<Product>>
        {
            Data = await _dataContext.Products
                .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                .Include(p => p.ProductVariants)
                .ToListAsync()
        };
        return response;
    }
    public async Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page)
    {
        var pageResults = 2f;
        var productsAll = await FindProductsBySearchText(searchText);
        var pageCount = Math.Ceiling(productsAll.Count / pageResults);

        var products = productsAll
            .Skip((page - 1) * (int)pageResults)
            .Take((int)pageResults)
            .ToList();

        var response = new ServiceResponse<ProductSearchResult>
        {
            Data = new ProductSearchResult
            {
                Products = products,
                CurrentPage = page,
                Pages = (int)pageCount
            }
        };

        return response;
    }
    private async Task<List<Product>> FindProductsBySearchText(string searchText)
    {
        return await _dataContext.Products.Where(
                p => p.Title.ToLower().Contains(searchText.ToLower())
                     ||
                     p.Description.ToLower().Contains(searchText.ToLower()))
            .Include(p => p.ProductVariants)
            .ToListAsync();
    }
    public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
    {
        var products = await FindProductsBySearchText(searchText);
        List<string> results = new List<string>();

        foreach (var product in products)
        {
            if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(product.Title);
            }

            if (product.Description != null)
            {
                var punctuation = product.Description.Where(char.IsPunctuation)
                    .Distinct().ToArray();
                var words = product.Description.Split()
                    .Select(s => s.Trim(punctuation));
                foreach (var word in words)
                {
                    if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                        && !results.Contains(word))
                    {
                        results.Add(word);
                    }
                }
            }
        }

        return new ServiceResponse<List<string>>
        {
            Data = results
        };
    }
    public async Task<ServiceResponse<List<Product>>> GetFeaturedProducts()
    {
        var response = new ServiceResponse<List<Product>>
        {
            Data = await _dataContext.Products
                .Where(p => p.Featured)
                .Include(p => p.ProductVariants)
                .ToListAsync()
        };

        return response;
    }
}