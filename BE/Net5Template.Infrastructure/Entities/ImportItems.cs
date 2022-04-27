using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ImportItems'.
    /// </summary>
    public partial class ImportItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportItems"/> class.
        /// </summary>
        public ImportItems()
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
        /// Gets or sets the property value representing column 'import_month'.
        /// </summary>
        /// <value>
        /// The property value representing column 'import_month'.
        /// </value>
        public long? ImportMonth { get; set; }

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
