using QuanLyKho.Models;

namespace QuanLyKho.Services
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllAsync();
    }
}
