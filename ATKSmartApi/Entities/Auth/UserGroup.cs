using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Entities.Auth
{
    public class UserGroup
    {
        [Required]
        [Key]
        public int UserGroupId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int StoreId { get; set; }

        [Required]
        public int GroupId { get; set; }
    }
}
