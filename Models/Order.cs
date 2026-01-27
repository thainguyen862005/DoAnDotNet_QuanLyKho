using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
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

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
    }
}