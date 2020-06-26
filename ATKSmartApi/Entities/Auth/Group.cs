using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATKSmartApi.Entities.Auth
{
    public class Group
    {
        [Required]
        [Key]
        public int GroupId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string GroupName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public int StoreId { get; set; }
    }
}
