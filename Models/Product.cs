using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
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

        [Column(TypeName = "decimal(18,2)")] // định dạng tiền tệ 
        public decimal Price { get; set; } = 0;

        public int Stock { get; set; } = 0;
    }
}