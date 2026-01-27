using Microsoft.EntityFrameworkCore;
using QuanLyKho.Data;
using QuanLyKho.Models;
using QuanLyKho.Services;    

namespace QuanLyKho.Services
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext _context;

        public BrandService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            return await _context.Brands.ToListAsync();
        }
    }
}
