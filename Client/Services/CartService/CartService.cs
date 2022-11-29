using Blazored.LocalStorage;
using MarketApp.Client.Shared;
using MarketApp.Shared;
using System.Net.Http.Json;

namespace MarketApp.Client.Services.CartService;

public class CartService : ICartService {
    private readonly ILocalStorageService _localStorageService;
    private readonly HttpClient _httpClient;

    public CartService(ILocalStorageService localStorageService, HttpClient httpClient)
    {
        _localStorageService = localStorageService;
        _httpClient = httpClient;
    }
    public event Action? OnChange;

    public async Task AddToCart(CartItem cartItem)
    {
        var cart = await GetLocalCart();
        cart.Add(cartItem);

        await _localStorageService.SetItemAsync("cart", cart);

        OnChange.Invoke();
    }

    public async Task<List<CartItem>> GetCartItems()
    {
        return await GetLocalCart();
    }

    public async Task<List<CartProductResponse>> GetCartProducts()
    {
        var cartItems = await GetLocalCart();
        var response = await _httpClient.PostAsJsonAsync("api/cart/products", cartItems);
        var cartProducts = 
            await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResponse>>>();
        return cartProducts.Data;
    }

    private async Task<List<CartItem>> GetLocalCart()
    {
        var cart = await _localStorageService.GetItemAsync<List<CartItem>>("cart");
        if (cart == null)
        {
            cart = new List<CartItem>();
        }
        return cart;
    }
}