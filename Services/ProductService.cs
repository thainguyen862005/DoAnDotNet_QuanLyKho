using Microsoft.EntityFrameworkCore;
using QuanLyKho.Data;
using QuanLyKho.Models;

namespace QuanLyKho.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _db;

        public ProductService(AppDbContext db)
        {
            _db = db;
        }
         public async Task<List<Product>> GetAllAsync()
        {
             return await _db.Products
            .Include(p => p.Brand)
            .ToListAsync();
        }
       public async Task<Product?> GetByIdAsync(int id)
        {
            return await _db.Products
                .AsNoTracking()
                .Include(p => p.Brand)
                .FirstOrDefaultAsync(p => p.Sp_id == id);
        }
        public async Task AddAsync(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
        }

         public async Task UpdateAsync(Product product)
        {
            var existing = await _db.Products.FindAsync(product.Sp_id);
            if (existing == null) return;

            existing.Sp_name = product.Sp_name;
            existing.Specifications = product.Specifications;
            existing.Description = product.Description;
            existing.Price = product.Price;
            existing.Quantity = product.Quantity;
            existing.Brands_id = product.Brands_id;
            existing.ImageUrl = product.ImageUrl;

            await _db.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var p = await _db.Products.FindAsync(id);
            if (p != null)
            {
                _db.Products.Remove(p);
                await _db.SaveChangesAsync();
            }
        }
    }
}
