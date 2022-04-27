using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'DM_Sys_Config'.
    /// </summary>
    public partial class DMSysConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMSysConfig"/> class.
        /// </summary>
        public DMSysConfig()
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
        /// Gets or sets the property value representing column 'sKey'.
        /// </summary>
        /// <value>
        /// The property value representing column 'sKey'.
        /// </value>
        public string SKey { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'sValue'.
        /// </summary>
        /// <value>
        /// The property value representing column 'sValue'.
        /// </value>
        public string SValue { get; set; }

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
