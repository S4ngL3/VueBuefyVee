using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class CheckListReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IntUserId { get; set; }

        public string StrUserName { get; set; }

        public int? IntGroupFor { get; set; }

        public int? IntObjectFor { get; set; }

        public int? IntShopId { get; set; }

        public int? IntGroupTaskId { get; set; }

        public long? IntParentId { get; set; }

        public long? IntTaskId { get; set; }

        public string StrTaskName { get; set; }

        public string StrTaskDescriptions { get; set; }

        public int? IntDone { get; set; }

        public int? IntSchedulesTime { get; set; }

        public int? IntCheckBy { get; set; }

        public long? IntCheckDate { get; set; }

        public long? IntModifyDate { get; set; }

        public int? IntModifyBy { get; set; }

        public long? IntChecklistDate { get; set; }

        public int? State { get; set; }

        public int? IntCreateBy { get; set; }

        public long? IntCreateDate { get; set; }

        public int? IntStartTime { get; set; }

        public int? IntEndTime { get; set; }

        public int? IntDMActive { get; set; }

        public int? IntCategoryTask { get; set; }

        public string StrQuantity { get; set; }

        #endregion

    }
}
