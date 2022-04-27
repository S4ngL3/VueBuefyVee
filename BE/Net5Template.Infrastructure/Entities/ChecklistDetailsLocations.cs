using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ChecklistDetailsLocations'.
    /// </summary>
    public partial class ChecklistDetailsLocations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistDetailsLocations"/> class.
        /// </summary>
        public ChecklistDetailsLocations()
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
        /// Gets or sets the property value representing column 'checklist_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'checklist_id'.
        /// </value>
        public long? ChecklistId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'shop_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'shop_id'.
        /// </value>
        public int? ShopId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'schedule_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'schedule_date'.
        /// </value>
        public long? ScheduleDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'province'.
        /// </summary>
        /// <value>
        /// The property value representing column 'province'.
        /// </value>
        public string Province { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'district'.
        /// </summary>
        /// <value>
        /// The property value representing column 'district'.
        /// </value>
        public string District { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ward'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ward'.
        /// </value>
        public string Ward { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'address'.
        /// </summary>
        /// <value>
        /// The property value representing column 'address'.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'state'.
        /// </summary>
        /// <value>
        /// The property value representing column 'state'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'create_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'create_date'.
        /// </value>
        public long? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'flag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'flag'.
        /// </value>
        public int? Flag { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
