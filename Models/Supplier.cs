using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [Column("Supplier_Id")]
        public int Supplier_Id { get; set; }

        [Column("SupplierName")]
        public string SupplierName { get; set; } = "";

        public string? ContactName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}
