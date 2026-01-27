using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("User_id")]
        public int User_id { get; set; }

        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password_hash { get; set; } = "";
        public string? Phone { get; set; }
        public string? Role { get; set; }
        public string? Status { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
