using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class UserIdsWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string StrUserName { get; set; }

        public string StrDeviceId { get; set; }

        public string StrFcmId { get; set; }

        public long? IntCreateDate { get; set; }

        public long? IntModifyDate { get; set; }

        public int? IntStatus { get; set; }

        public int? IntType { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
