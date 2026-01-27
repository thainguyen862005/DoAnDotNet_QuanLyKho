using QuanLyKho.Models;

namespace QuanLyKho.Services
{
    public interface IPaymentService
    {
        void SetCart(List<CartItem> cart);
        List<CartItem> GetCurrentCart();
        Task PayAsync(string customerName);
        void ClearCart();
    }
}