using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class ChecklistDetailsItemsReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long? ChecklistId { get; set; }

        public string ItemsCode { get; set; }

        public int? ShopId { get; set; }

        public long? ScheduleDate { get; set; }

        public int? QuantityPlan { get; set; }

        public int? QuantityReal { get; set; }

        public int? State { get; set; }

        public long? CreateDate { get; set; }

        #endregion

    }
}
