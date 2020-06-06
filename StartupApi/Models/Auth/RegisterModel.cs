using System.ComponentModel.DataAnnotations;

namespace StartupApi.Models.Auth
{
    public class RegisterModel : CommonModel
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(32)]
        [StringLength(32, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
