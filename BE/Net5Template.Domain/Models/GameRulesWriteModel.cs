using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class GameRulesWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string StrTitle { get; set; }

        public string StrContent { get; set; }

        public long? IntValidDateFrom { get; set; }

        public long? IntValidDateTo { get; set; }

        public int? IntStatus { get; set; }

        public int? IntSort { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
