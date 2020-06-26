using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Models.Auth
{
    public class AuthenticateModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
