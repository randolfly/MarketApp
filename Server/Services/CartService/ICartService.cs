using MarketApp.Client.Shared;
using MarketApp.Shared;

namespace MarketApp.Server.Services.CartService; 

public interface ICartService {
    Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
}