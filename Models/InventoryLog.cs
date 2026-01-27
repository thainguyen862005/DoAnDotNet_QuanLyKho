using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
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
        public string Type { get; set; } = "Nhập"; // Nhập hoặc Xuất

        public int Quantity { get; set; }

        [MaxLength(100)]
        public string StaffName { get; set; } = "";

        [MaxLength(500)]
        public string Note { get; set; } = "";
    }
}