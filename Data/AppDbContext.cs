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