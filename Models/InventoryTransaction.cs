using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("Inventory_Transactions")]
    public class InventoryTransaction
    {
        [Key]
        [Column("TransactionID")]
        public int TransactionID { get; set; }

        [Column("UserID")]
        public int? UserID { get; set; }

        [Column("SupplierID")]
        public int? SupplierID { get; set; }

        [Column("Type")]
        public string Type { get; set; } = "";

        [Column("TransactionDate")]
        public DateTime TransactionDate { get; set; }

        [Column("Note")]
        public string? Note { get; set; }

        [ForeignKey("UserID")]
        public User? User { get; set; }

        [ForeignKey("SupplierID")]
        public Supplier? Supplier { get; set; }

        public ICollection<TransactionDetail>? Details { get; set; }
    }
}
