using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'WCdetails'.
    /// </summary>
    public partial class WCdetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WCdetails"/> class.
        /// </summary>
        public WCdetails()
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
        /// Gets or sets the property value representing column 'int_workcalendar_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_workcalendar_id'.
        /// </value>
        public long? IntWorkcalendarId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_shop_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_shop_id'.
        /// </value>
        public int? IntShopId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_shop_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_shop_name'.
        /// </value>
        public string StrShopName { get; set; }

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
