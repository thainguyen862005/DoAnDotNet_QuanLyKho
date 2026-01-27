using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; } = "";

        [Required, MaxLength(100)]
        public string Email { get; set; } = "";

        [Required, MaxLength(100)]
        public string Password { get; set; } = "";

        [MaxLength(20)]
        public string Phone { get; set; } = "";

        public int Role { get; set; } = 0; // 0: Staff, 1: Admin

        [MaxLength(20)]
        public string Status { get; set; } = "Active";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}