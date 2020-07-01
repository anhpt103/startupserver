using ATKSmartApi.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Models.Auth
{
    public class AuthenticateModel
    {
        [StringLength(50, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_LENGTH_INVALID))]
        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_REQUIRE))]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_INVALID))]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessageResourceType = typeof(string), ErrorMessageResourceName = nameof(ValidateModel.PASSWORD_REQUIRE))]
        [StringLength(32, ErrorMessageResourceType = typeof(string), ErrorMessageResourceName = nameof(ValidateModel.PASSWORD_LENGTH_INVALID), MinimumLength = 6)]
        public string Password { get; set; }
    }
}
