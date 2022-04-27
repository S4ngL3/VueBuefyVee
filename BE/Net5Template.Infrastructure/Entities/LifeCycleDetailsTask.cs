using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'LifeCycleDetailsTask'.
    /// </summary>
    public partial class LifeCycleDetailsTask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LifeCycleDetailsTask"/> class.
        /// </summary>
        public LifeCycleDetailsTask()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'id'.
        /// </value>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_lifecycle_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_lifecycle_id'.
        /// </value>
        public long IntLifecycleId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_task_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_task_id'.
        /// </value>
        public long IntTaskId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_region_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_region_id'.
        /// </value>
        public int IntRegionId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'state'.
        /// </summary>
        /// <value>
        /// The property value representing column 'state'.
        /// </value>
        public int? State { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
