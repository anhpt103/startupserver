using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Entities.Auth
{
    public class GroupMenu
    {
        [Required]
        public string Menu { get; set; }

        [Required]
        public int GroupId { get; set; }

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
