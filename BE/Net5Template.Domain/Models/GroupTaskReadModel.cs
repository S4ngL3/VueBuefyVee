using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class GroupTaskReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string StrCode { get; set; }

        public string StrName { get; set; }

        public string StrDescriptions { get; set; }

        public long? IntParentId { get; set; }

        public int? IntGroupFor { get; set; }

        public int? IntRegionFor { get; set; }

        public int? IntObjectFor { get; set; }

        public int? IntActive { get; set; }

        public long? IntCreateDate { get; set; }

        public long? IntModifyDate { get; set; }

        public long? IntCreateBy { get; set; }

        public int? State { get; set; }

        public int? IntGroupBy { get; set; }

        #endregion

    }
}
