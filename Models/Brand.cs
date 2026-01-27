using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("Brands")]
    public class Brand
    {
        [Key]
        [Column("Brand_Id")]
        public int Brand_Id { get; set; }

        [Column("Brand_name")]
        public string Brand_name { get; set; } = "";

        public ICollection<Product>? Products { get; set; }
    }
}
