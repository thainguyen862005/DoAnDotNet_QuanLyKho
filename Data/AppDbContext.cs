using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@gmail.com",
                    Password = "123",
                    Role = 1,
                    Status = "Active",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    Username = "staff",
                    Email = "staff@gmail.com",
                    Password = "123",
                    Role = 0,
                    Status = "Active",
                    CreatedAt = DateTime.Now
                }
            );
        }
    }

    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string Password { get; set; } = "";

        [MaxLength(20)]
        public string Phone { get; set; } = "";

        public int Role { get; set; } = 0;

        [MaxLength(20)]
        public string Status { get; set; } = "Active";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = "";

        [Required]
        [MaxLength(50)]
        public string SKU { get; set; } = "";

        [MaxLength(50)]
        public string Brand { get; set; } = "";

        [MaxLength(50)]
        public string Storage { get; set; } = "";

        public decimal Price { get; set; } = 0;

        public int Stock { get; set; } = 0; 
    }

    [Table("InventoryLogs")]
    public class InventoryLog
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(200)]
        public string ProductName { get; set; } = "";
        [MaxLength(50)]
        public string SKU { get; set; } = "";

        [Required]
        [MaxLength(20)]
        public string Type { get; set; } = "Nh?p";

        public int Quantity { get; set; }

        [MaxLength(100)]
        public string StaffName { get; set; } = "";

        [MaxLength(500)]
        public string Note { get; set; } = "";
    }

    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        [MaxLength(200)]
        public string CustomerName { get; set; } = "";

        [MaxLength(200)]
        public string StaffName { get; set; } = "";

        [Required]
        public string ProductName { get; set; } = "";

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalAmount { get; set; }
    }
}