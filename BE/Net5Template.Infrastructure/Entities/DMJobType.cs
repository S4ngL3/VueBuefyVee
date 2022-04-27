using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'DM_JobType'.
    /// </summary>
    public partial class DMJobType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMJobType"/> class.
        /// </summary>
        public DMJobType()
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
        /// Gets or sets the property value representing column 'job_type'.
        /// </summary>
        /// <value>
        /// The property value representing column 'job_type'.
        /// </value>
        public int? JobType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'job_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'job_name'.
        /// </value>
        public string JobName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_category_task'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_category_task'.
        /// </value>
        public string IntCategoryTask { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'delimiter'.
        /// </summary>
        /// <value>
        /// The property value representing column 'delimiter'.
        /// </value>
        public string Delimiter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'sFilter'.
        /// </summary>
        /// <value>
        /// The property value representing column 'sFilter'.
        /// </value>
        public string SFilter { get; set; }

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
