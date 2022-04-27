using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class ShopItemsWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? ShopId { get; set; }

        public string ItemsCode { get; set; }

        public int? Quantity { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
