using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class FGiftWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IntGiftId { get; set; }

        public string FGiftTitle { get; set; }

        public string FGiftContent { get; set; }

        public Byte[] FCoin { get; set; }

        public int? IntStatus { get; set; }

        public string StrUrl { get; set; }

        public int? IntSort { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
