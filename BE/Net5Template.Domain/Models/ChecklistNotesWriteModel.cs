using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class ChecklistNotesWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long? IntChecklistId { get; set; }

        public string StrUserName { get; set; }

        public string StrContent { get; set; }

        public long? IntCreateDate { get; set; }

        public int? State { get; set; }

        public long? IntChecklistDate { get; set; }

        #endregion

    }
}
