using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class ChecklistFileWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long? IntChecklistId { get; set; }

        public string StrName { get; set; }

        public string StrPath { get; set; }

        public int? IntStatus { get; set; }

        public long? IntCreateDate { get; set; }

        public long? IntModifyDate { get; set; }

        public int? IntCreateBy { get; set; }

        public int? State { get; set; }

        public long? IntChecklistDate { get; set; }

        public string StrUserName { get; set; }

        public double? IntLat { get; set; }

        public double? IntLong { get; set; }

        #endregion

    }
}
