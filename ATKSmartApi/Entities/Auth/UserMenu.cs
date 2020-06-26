using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Entities.Auth
{
    public class UserMenu
    {
        [Required]
        public string Menu { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int StoreId { get; set; }

        [Required]
        public bool View { get; set; }

        [Required]
        public bool Add { get; set; }

        [Required]
        public bool Edit { get; set; }

        [Required]
        public bool Delete { get; set; }
    }
}
