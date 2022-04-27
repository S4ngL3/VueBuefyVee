using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class NotifyRealtimeWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IntUserId { get; set; }

        public string StrUserName { get; set; }

        public string StrCode { get; set; }

        public string StrTitle { get; set; }

        public string StrContent { get; set; }

        public string StrContentOld { get; set; }

        public string StrContentNew { get; set; }

        public int? IntStatus { get; set; }

        public int? State { get; set; }

        public long? IntCreateDate { get; set; }

        public int? IntUserIdUpdateWc { get; set; }

        public string StrUserNameUpdateWc { get; set; }

        public long? SessionKey { get; set; }

        #endregion

    }
}
