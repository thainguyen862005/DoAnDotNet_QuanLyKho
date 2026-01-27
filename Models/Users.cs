using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKho.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("User_id")]
        public int User_id { get; set; }

        [Column("Username")]
        public string Username { get; set; } = "";

        [Column("Password_hash")]
        public string Password_hash { get; set; } = "";

        [Column("Email")]
        public string? Email { get; set; }

         
        [Column("Phone")]
        public string? Phone { get; set; } 
        // --------------------------------

        [Column("Role")]
        public string Role { get; set; } = "staff";

        [Column("Status")]
        public string Status { get; set; } = "Active";

        [Column("CreateAt")]
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}