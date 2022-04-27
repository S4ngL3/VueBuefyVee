using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class PgdWorkCalendarReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IntShopId { get; set; }

        public int? IntUserId { get; set; }

        public string StrUserName { get; set; }

        public string UserFullName { get; set; }

        public long? IntSchedulesDate { get; set; }

        public int? IntShiftsId { get; set; }

        public int? IntCreateBy { get; set; }

        public long? IntCreateDate { get; set; }

        public int? IntModifyBy { get; set; }

        public long? IntModifyDate { get; set; }

        public string StrNotes { get; set; }

        public int? IntStatus { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
