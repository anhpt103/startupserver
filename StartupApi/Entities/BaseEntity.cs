using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartupApi.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        [MaxLength(20)]
        [Column(TypeName = "varchar(50)")]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(50)")]
        public string UpdateBy { get; set; }
    }
}
