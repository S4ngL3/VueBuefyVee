using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class TaskWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string StrCode { get; set; }

        public string StrName { get; set; }

        public string StrDescriptions { get; set; }

        public int? IntSchedulesTime { get; set; }

        public string StrApprovals { get; set; }

        public long? IntParentId { get; set; }

        public int? IntGroupTaskId { get; set; }

        public int? IntSubtask { get; set; }

        public int? IntActive { get; set; }

        public long? IntCreateDate { get; set; }

        public long? IntModifyDate { get; set; }

        public long? IntCreateBy { get; set; }

        public int? State { get; set; }

        public int? IntStartTime { get; set; }

        public int? IntEndTime { get; set; }

        public int? IntDMActive { get; set; }

        public int? IntCategoryTask { get; set; }

        public string StrQuantity { get; set; }

        public int? AttachmentsRequired { get; set; }

        public int? Plus { get; set; }

        public int? Minus { get; set; }

        #endregion

    }
}
