using ATKSmartApi.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Models.Auth
{
    public class StoreModel
    {
        // [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.STOREID_REQUIRE))]
        public int? StoreId { get; set; }

        [Required(ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.STORE_REQUIRE))]
        [StringLength(50, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.STORE_LENGTH_INVALID))]
        public string StoreName { get; set; }

        [StringLength(100, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.ADDRESS_LENGTH_INVALID))]
        public string Address { get; set; }
    }
}
