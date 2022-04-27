using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ChecklistDetailsItems'.
    /// </summary>
    public partial class ChecklistDetailsItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistDetailsItems"/> class.
        /// </summary>
        public ChecklistDetailsItems()
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
        /// Gets or sets the property value representing column 'items_code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'items_code'.
        /// </value>
        public string ItemsCode { get; set; }

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
        /// Gets or sets the property value representing column 'quantity_plan'.
        /// </summary>
        /// <value>
        /// The property value representing column 'quantity_plan'.
        /// </value>
        public int? QuantityPlan { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'quantity_real'.
        /// </summary>
        /// <value>
        /// The property value representing column 'quantity_real'.
        /// </value>
        public int? QuantityReal { get; set; }

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

        #endregion

        #region Generated Relationships
        #endregion

    }
}
