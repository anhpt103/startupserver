using ATKSmartApi.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Models.Auth
{
    public class UserProfileModel
    {
        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.USERID_REQUIRE))]
        public int UserId { get; set; }

        public int? UserProfileId { get; set; }

        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.FIRSTNAME_REQUIRE))]
        [StringLength(30, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.FIRSTNAME_LENGTH_INVALID))]
        public string FirstName { get; set; }

        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.LASTNAME_REQUIRE))]
        [StringLength(30, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.LASTNAME_LENGTH_INVALID))]
        public string LastName { get; set; }

        [StringLength(100, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.ADDRESS_LENGTH_INVALID))]
        public string Address { get; set; }

        [StringLength(50, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_LENGTH_INVALID))]
        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_REQUIRE))]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_INVALID))]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessageResourceType = typeof(string), ErrorMessageResourceName = nameof(ValidateModel.PASSWORD_REQUIRE))]
        [StringLength(32, ErrorMessageResourceType = typeof(string), ErrorMessageResourceName = nameof(ValidateModel.PASSWORD_LENGTH_INVALID), MinimumLength = 6)]
        public string Password { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.PHONENUMBER_INVALID))]
        [StringLength(15, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.PHONENUMBER_LENGTH_INVALID), MinimumLength = 10)]
        public string PhoneNumber { get; set; }
    }
}
