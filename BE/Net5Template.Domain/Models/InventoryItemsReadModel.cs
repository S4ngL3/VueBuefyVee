using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class InventoryItemsReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? ShopId { get; set; }

        public string ItemsCode { get; set; }

        public int? QuantityReal { get; set; }

        public int? QuantitySystem { get; set; }

        public string Explanation { get; set; }

        public long? InventoryMonth { get; set; }

        public long? CreateDate { get; set; }

        public int? CreateBy { get; set; }

        public long? ModifyDate { get; set; }

        public int? ModifyBy { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
