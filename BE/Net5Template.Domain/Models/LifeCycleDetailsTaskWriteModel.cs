using System;
using System.Collections.Generic;

namespace Net5Template.Domain.Models
{
    public partial class LifeCycleDetailsTaskWriteModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IntLifecycleId { get; set; }

        public long IntTaskId { get; set; }

        public int IntRegionId { get; set; }

        public int? State { get; set; }

        #endregion

    }
}
