using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'DM_Active'.
    /// </summary>
    public partial class DMActive
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMActive"/> class.
        /// </summary>
        public DMActive()
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
        /// Gets or sets the property value representing column 'int_active_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_active_id'.
        /// </value>
        public int? IntActiveId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_active_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_active_name'.
        /// </value>
        public string StrActiveName { get; set; }

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
