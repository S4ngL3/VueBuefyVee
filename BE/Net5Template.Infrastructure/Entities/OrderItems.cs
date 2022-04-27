using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'OrderItems'.
    /// </summary>
    public partial class OrderItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItems"/> class.
        /// </summary>
        public OrderItems()
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
        /// Gets or sets the property value representing column 'shop_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'shop_id'.
        /// </value>
        public int? ShopId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'items_code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'items_code'.
        /// </value>
        public string ItemsCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'quantity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'quantity'.
        /// </value>
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'notes'.
        /// </summary>
        /// <value>
        /// The property value representing column 'notes'.
        /// </value>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'create_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'create_date'.
        /// </value>
        public long? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'create_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'create_by'.
        /// </value>
        public int? CreateBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'modify_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'modify_date'.
        /// </value>
        public long? ModifyDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'modify_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'modify_by'.
        /// </value>
        public int? ModifyBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'order_month'.
        /// </summary>
        /// <value>
        /// The property value representing column 'order_month'.
        /// </value>
        public long? OrderMonth { get; set; }

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
