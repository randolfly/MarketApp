using MarketApp.Shared;
namespace MarketApp.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<Product[]>> GetProductAsync();
}