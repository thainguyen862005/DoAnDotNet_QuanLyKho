using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }

        public int SpItemId { get; set; }

        public ProductItem? ProductItem { get; set; }
        
        public string ProductName { get; set; } = "";
        
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        // Tổng tiền của item
        [NotMapped]
        public decimal Total => Price * Quantity;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}