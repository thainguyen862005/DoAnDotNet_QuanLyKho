    using Microsoft.EntityFrameworkCore;
    using QuanLyKho.Models;
    using QuanLyKho.Services;       

    namespace QuanLyKho.Services
    {
        public class PaymentService : IPaymentService
        {
          private List<CartItem> _cart = new();

    public void SetCart(List<CartItem> cart)
    {
        _cart = cart
            .Select(x => new CartItem
            {
                SpItemId = x.SpItemId,
                ProductName = x.ProductName,
                Quantity = x.Quantity,
                Price = x.Price
            })
            .ToList();
    }

    public List<CartItem> GetCurrentCart()
    {
        return _cart;
    }

    public Task PayAsync(string customerName)
    {
        return Task.CompletedTask;
    }

    public void ClearCart()
    {
        _cart.Clear();
    }
    }
    }
