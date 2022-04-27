using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class DMItemsWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string ItemsCode { get; set; }

        public string ItemsName { get; set; }

        public string Descriptions { get; set; }

        public long? IntCreateDate { get; set; }

        public int? IntCreateBy { get; set; }

        public long? IntModifyDate { get; set; }

        public int? IntModifyBy { get; set; }

        public long? IntDMUnitId { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
