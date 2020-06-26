using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATKSmartApi.Entities.Auth
{
    public class UserProfile
    {
        [Key]
        public int UserProfileId { get; set; }

        [Required]
        public int UserId { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }


        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
    }
}
