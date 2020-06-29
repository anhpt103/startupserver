using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Models.Auth
{
    public class UserProfileModel
    {
        [Required]
        public int UserId { get; set; }

        [MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(32)]
        [StringLength(32, MinimumLength = 6)]
        public string Password { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
}
