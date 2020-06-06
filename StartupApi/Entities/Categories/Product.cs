using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartupApi.Entities.Categories
{
    public class Product : BaseEntity
    {
        [MaxLength(20)]
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Code { get; set; }

        [MaxLength(100)]
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        public int TaxId { get; set; }

        public int? UnitCalcId { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
