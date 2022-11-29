using MarketApp.Client.Shared;
using MarketApp.Shared;

namespace MarketApp.Client.Services.CartService; 

public interface ICartService {
    event Action OnChange;
    Task AddToCart(CartItem cartItem);
    Task<List<CartItem>> GetCartItems();

    Task<List<CartProductResponse>> GetCartProducts();
}