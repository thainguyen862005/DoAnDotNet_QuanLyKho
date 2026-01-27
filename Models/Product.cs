using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("Sp")]
    public class Product
    {
        [Key]
        [Column("Sp_id")]
        public int Sp_id { get; set; }

        [Column("Brands_id")]
        public int? Brands_id { get; set; }

        [Column("Sp_name")]
        public string Sp_name { get; set; } = "";

        [Column("Specifications")]
        public string? Specifications { get; set; }

        [Column("Description")]
        public string? Description { get; set; }

        // Navigation
        [ForeignKey(nameof(Brands_id))]
        public Brand? Brand { get; set; }

        public ICollection<ProductItem> Items { get; set; } = new List<ProductItem>();
    }
}
