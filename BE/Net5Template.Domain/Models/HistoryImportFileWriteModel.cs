using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class HistoryImportFileWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string Path { get; set; }

        public string Capacity { get; set; }

        public long? IntCreateDate { get; set; }

        public int? IntCreateBy { get; set; }

        public long? IntModifyDate { get; set; }

        public int? IntModifyBy { get; set; }

        public int? IntRowSuccess { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
