using System;
using System.ComponentModel.DataAnnotations;

namespace StartupApi.Models
{
    public class CommonModel
    {

        public DateTime CreateDate { get; set; }

        [MaxLength(50)]
        public string CreateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        [MaxLength(50)]
        public string UpdateBy { get; set; }
    }
}
