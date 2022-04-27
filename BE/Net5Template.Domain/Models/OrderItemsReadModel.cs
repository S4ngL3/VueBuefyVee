using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class OrderItemsReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? ShopId { get; set; }

        public string ItemsCode { get; set; }

        public int? Quantity { get; set; }

        public string Notes { get; set; }

        public long? CreateDate { get; set; }

        public int? CreateBy { get; set; }

        public long? ModifyDate { get; set; }

        public int? ModifyBy { get; set; }

        public long? OrderMonth { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
