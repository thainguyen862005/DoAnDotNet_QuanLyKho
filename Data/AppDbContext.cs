using Microsoft.EntityFrameworkCore;
using QuanLyKho.Models; 

namespace QuanLyKho.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductItem> ProductItems => Set<ProductItem>();
        public DbSet<InventoryTransaction> InventoryTransactions => Set<InventoryTransaction>();
        public DbSet<TransactionDetail> TransactionDetails => Set<TransactionDetail>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Order> Orders => Set<Order>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed dữ liệu Admin mặc định
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    User_id = 1,
                    Username = "admin",
                    Email = "admin@gmail.com",
                    Password_hash = "123", // Lưu ý: Thực tế nên mã hóa MD5/BCrypt
                    Role = "admin",
                    Status = "Active",
                    CreateAt = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}