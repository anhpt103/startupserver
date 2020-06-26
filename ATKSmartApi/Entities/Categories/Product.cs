using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATKSmartApi.Entities.Categories
{
    public class Product : BaseEntity
    {
        [Key]
        public int ProductId { get; set; }

        [MaxLength(5)]
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ProductCode { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(150)")]
        public string ProductName { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        public int TaxId { get; set; }

        public int? UnitCalcId { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        public decimal ProductInventory { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string Description { get; set; }

        public Nullable<int> Status { get; set; }
    }
}
