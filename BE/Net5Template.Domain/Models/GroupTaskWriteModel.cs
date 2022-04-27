using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Net5Template.Domain.Models
{
    public partial class GroupTaskWriteModel : OperationModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string StrCode { get; set; }

        [Required(ErrorMessage = "Trường dữ liệu bắt buộc.")]
        [StringLength(50, ErrorMessage = "Số lượng ký tự tối đa cho phép là 50")]
        public string StrName { get; set; }

        public string StrDescriptions { get; set; }

        public long? IntParentId { get; set; }

        [Required(ErrorMessage = "Trường dữ liệu bắt buộc.")]
        [Range(1, 10, ErrorMessage = "Trường dữ liệu bắt buộc.")]
        public int? IntGroupFor { get; set; }

        public int? IntRegionFor { get; set; }

        [Required(ErrorMessage = "Trường dữ liệu bắt buộc.")]
        [Range(1, 10, ErrorMessage = "Trường dữ liệu bắt buộc.")]
        public int? IntObjectFor { get; set; }

        public int? IntActive { get; set; }

        public long? IntCreateDate { get; set; }

        public long? IntModifyDate { get; set; }

        public long? IntCreateBy { get; set; }

        public int? State { get; set; }

        [Required(ErrorMessage = "Trường dữ liệu bắt buộc.")]
        [Range(1, int.MaxValue, ErrorMessage = "Thứ tự phải lớn hơn 0")]
        public int? IntGroupBy { get; set; }

        #endregion

    }
}
