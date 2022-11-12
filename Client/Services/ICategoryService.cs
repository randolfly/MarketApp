using MarketApp.Shared;

namespace MarketApp.Client.Services;

public interface ICategoryService {
    List<Category>? Categories { get; set; }
    Task GetCategories();

}