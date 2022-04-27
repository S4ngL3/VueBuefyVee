using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'DM_LifeCyclePGD'.
    /// </summary>
    public partial class DMLifeCyclePGD
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMLifeCyclePGD"/> class.
        /// </summary>
        public DMLifeCyclePGD()
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
        public int? IntLifecycleId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_lifecycle_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_lifecycle_name'.
        /// </value>
        public string StrLifecycleName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_order_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_order_by'.
        /// </value>
        public int? IntOrderBy { get; set; }

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
