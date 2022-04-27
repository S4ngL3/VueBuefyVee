using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class ChecklistDetailsLocationsReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long? ChecklistId { get; set; }

        public int? ShopId { get; set; }

        public long? ScheduleDate { get; set; }

        public string Province { get; set; }

        public string District { get; set; }

        public string Ward { get; set; }

        public string Address { get; set; }

        public int? State { get; set; }

        public long? CreateDate { get; set; }

        public int? Flag { get; set; }

        #endregion

    }
}
