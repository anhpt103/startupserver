using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Entities.Auth
{
    public class UserStore
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int StoreId { get; set; }
    }
}
