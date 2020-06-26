using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATKSmartApi.Entities
{
    public class BaseEntity
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [MaxLength(20)]
        [Column(TypeName = "varchar(50)")]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(50)")]
        public string UpdateBy { get; set; }

        public int StoreId { get; set; }
    }
}
