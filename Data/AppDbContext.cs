using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using QuanLyKho.Models; 

namespace QuanLyKho.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InventoryLog> InventoryLogs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed dữ liệu Admin mặc định
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@gmail.com",
                    Password = "123", // Lưu ý: Thực tế nên mã hóa MD5/BCrypt
                    Role = 1,
                    Status = "Active",
                    CreatedAt = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}