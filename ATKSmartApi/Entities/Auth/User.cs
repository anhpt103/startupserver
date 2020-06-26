using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ATKSmartApi.Entities.Auth
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Username { get; set; }

        [Required]
        [MaxLength(32)]
        [JsonIgnore]
        [Column(TypeName = "varchar(32)")]
        public string Password { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Token { get; set; }
    }
}
