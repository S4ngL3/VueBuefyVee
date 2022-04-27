using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class FExchangeWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IntExchangeId { get; set; }

        public string FExchangeName { get; set; }

        public Byte[] FCoin { get; set; }

        public int? IntStatus { get; set; }

        public string StrUrl { get; set; }

        public int? IntQuantity { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
