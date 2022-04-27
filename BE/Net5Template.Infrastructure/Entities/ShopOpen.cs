using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Shop_Open'.
    /// </summary>
    public partial class ShopOpen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopOpen"/> class.
        /// </summary>
        public ShopOpen()
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
        /// Gets or sets the property value representing column 'int_shop_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_shop_id'.
        /// </value>
        public int? IntShopId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_code'.
        /// </value>
        public string StrCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'open_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'open_date'.
        /// </value>
        public long? OpenDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_name'.
        /// </value>
        public string StrName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'area_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'area_id'.
        /// </value>
        public int? AreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'state'.
        /// </summary>
        /// <value>
        /// The property value representing column 'state'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'open_date_customization'.
        /// </summary>
        /// <value>
        /// The property value representing column 'open_date_customization'.
        /// </value>
        public long? OpenDateCustomization { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
