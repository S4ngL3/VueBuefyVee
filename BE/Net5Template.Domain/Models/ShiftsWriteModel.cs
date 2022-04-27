using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class ShiftsWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IntShiftsId { get; set; }

        public string StrShiftsName { get; set; }

        public string IntTimeFrom { get; set; }

        public string IntTimeTo { get; set; }

        public string StrNotes { get; set; }

        public int? IntStatus { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
