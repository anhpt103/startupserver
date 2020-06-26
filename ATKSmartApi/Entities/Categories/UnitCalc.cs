using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATKSmartApi.Entities.Categories
{
    public class UnitCalc : BaseEntity
    {
        [Key]
        public int UnitCalcId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string UnitCalcName { get; set; }

        public Nullable<int> Status { get; set; }
    }
}
