using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("Transaction_detail")]
    public class TransactionDetail
    {
        [Key]
        [Column("DetailID")]
        public int DetailID { get; set; }

        [Column("TransactionID")]
        public int TransactionID { get; set; }

        [Column("Sp_item_ID")]
        public int Sp_item_ID { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("UnitPrice")]
        public decimal UnitPrice { get; set; }

        // Navigation
        [ForeignKey(nameof(TransactionID))]
        public InventoryTransaction? Transaction { get; set; }

        [ForeignKey(nameof(Sp_item_ID))]
        public ProductItem? ProductItem { get; set; }
    }
}
