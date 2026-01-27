using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("SP_item")]
    public class ProductItem
    {
        [Key]
        [Column("Sp_item_id")]
        public int Sp_item_id { get; set; }

        [Column("Sp_id")]
        public int Sp_id { get; set; }

        [Column("SKU")]
        public string SKU { get; set; } = "";

        [Column("Color")]
        public string? Color { get; set; }

        [Column("Storage")]
        public string? Storage { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("StockQuantity")]
        public int StockQuantity { get; set; }

        // Navigation
        [ForeignKey(nameof(Sp_id))]
        public Product? Product { get; set; }

        public ICollection<TransactionDetail>? TransactionDetails { get; set; }
    }
}
