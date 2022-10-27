using MarketApp.Server.Data;
using MarketApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace MarketApp.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly DataContext _dataContext;

    public ProductService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    public async Task<ServiceResponse<Product[]>> GetProductAsync()
    {
        var response = new ServiceResponse<Product[]>()
        {
            Data = await _dataContext.Products.ToArrayAsync()
        };
        return response;
    }
}