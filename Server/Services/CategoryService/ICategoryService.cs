using MarketApp.Shared;

namespace MarketApp.Server.Services.CategoryService;

public interface ICategoryService
{
    Task<ServiceResponse<List<Category>>> GetCategories();
}