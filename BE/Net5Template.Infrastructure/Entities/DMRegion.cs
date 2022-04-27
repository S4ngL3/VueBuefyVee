using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'DM_Region'.
    /// </summary>
    public partial class DMRegion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMRegion"/> class.
        /// </summary>
        public DMRegion()
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
        /// Gets or sets the property value representing column 'int_region_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_region_id'.
        /// </value>
        public int? IntRegionId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_region_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_region_name'.
        /// </value>
        public string StrRegionName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'state'.
        /// </summary>
        /// <value>
        /// The property value representing column 'state'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'color'.
        /// </summary>
        /// <value>
        /// The property value representing column 'color'.
        /// </value>
        public string Color { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
