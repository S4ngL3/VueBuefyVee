using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class FCoinReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IntShopId { get; set; }

        public int? IntUserId { get; set; }

        public Byte[] FCoinMember { get; set; }

        public Byte[] FCoinExchange { get; set; }

        public long? IntCreateDate { get; set; }

        public long? IntModifyDate { get; set; }

        public int? IntStatus { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
