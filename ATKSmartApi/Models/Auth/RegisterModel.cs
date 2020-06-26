using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Models.Auth
{
    public class RegisterModel
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(32)]
        [StringLength(32, MinimumLength = 6)]
        public string Password { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Captcha { get; set; }
    }
}
