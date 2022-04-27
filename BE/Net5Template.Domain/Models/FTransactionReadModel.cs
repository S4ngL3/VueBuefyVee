using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class FTransactionReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IntShopId { get; set; }

        public int? IntUserId { get; set; }

        public int? IntExchangeId { get; set; }

        public int? IntGiftId { get; set; }

        public string StrName { get; set; }

        public Byte[] FCoin { get; set; }

        public Byte[] FCoinTotal { get; set; }

        public Byte[] FCoinExchangeTotal { get; set; }

        public long? IntChecklistDate { get; set; }

        public long? IntChecklistId { get; set; }

        public long? IntCreateDate { get; set; }

        public int? IntCreateBy { get; set; }

        public long? IntModifyDate { get; set; }

        public int? IntModifyBy { get; set; }

        public int? IntStatus { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
