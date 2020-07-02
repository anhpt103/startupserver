using ATKSmartApi.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Models.Auth
{
    public class UserStoreModel
    {
        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.STOREID_REQUIRE))]
        public int StoreId { get; set; }

        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.USERID_REQUIRE))]
        public int UserId { get; set; }

        [StringLength(50, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_LENGTH_INVALID))]
        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_REQUIRE))]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.EMAIL_INVALID))]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.PASSWORD_REQUIRE))]
        [StringLength(32, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.PASSWORD_LENGTH_INVALID), MinimumLength = 6)]
        public string Password { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.PHONENUMBER_INVALID))]
        [StringLength(15, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.PHONENUMBER_LENGTH_INVALID), MinimumLength = 10)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Token { get; set; }
    }
}
