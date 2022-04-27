using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'TaskDetailsItems'.
    /// </summary>
    public partial class TaskDetailsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDetailsItems"/> class.
        /// </summary>
        public TaskDetailsItems()
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
        /// Gets or sets the property value representing column 'task_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'task_id'.
        /// </value>
        public int? TaskId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'items_code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'items_code'.
        /// </value>
        public string ItemsCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'region'.
        /// </summary>
        /// <value>
        /// The property value representing column 'region'.
        /// </value>
        public int? Region { get; set; }

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
