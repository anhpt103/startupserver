using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATKSmartApi.Entities.Categories
{
    public class Tax : BaseEntity
    {
        [Key]
        public int TaxId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string TaxName { get; set; }

        public decimal TaxValue { get; set; }

        public Nullable<int> Status { get; set; }
    }
}
