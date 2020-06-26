using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATKSmartApi.Entities.Categories
{
    public class Supplier : BaseEntity
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        [MaxLength(150)]
        [Column(TypeName = "nvarchar(150)")]
        public string SupplierName { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [MaxLength(150)]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string Description { get; set; }

        public Nullable<int> Status { get; set; }
    }
}
