using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'DM_CategoryTask'.
    /// </summary>
    public partial class DMCategoryTask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMCategoryTask"/> class.
        /// </summary>
        public DMCategoryTask()
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
        /// Gets or sets the property value representing column 'int_category_task_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_category_task_id'.
        /// </value>
        public int? IntCategoryTaskId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_category_task_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_category_task_name'.
        /// </value>
        public string StrCategoryTaskName { get; set; }

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
