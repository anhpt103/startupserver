using ATKSmartApi.Common.Constants;
using System;
using System.ComponentModel.DataAnnotations;

namespace ATKSmartApi.Models
{
    public class CommonModel
    {
        public DateTime CreateDate { get; set; }

        [StringLength(50, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.CREATEBY_LENGTH_INVALID))]
        public string CreateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        [StringLength(50, ErrorMessageResourceType = typeof(string), ErrorMessage = nameof(ValidateModel.UPDATEBY_LENGTH_INVALID))]
        public string UpdateBy { get; set; }
    }
}
