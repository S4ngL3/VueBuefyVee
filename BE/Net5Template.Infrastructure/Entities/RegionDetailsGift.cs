using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'RegionDetailsGift'.
    /// </summary>
    public partial class RegionDetailsGift
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionDetailsGift"/> class.
        /// </summary>
        public RegionDetailsGift()
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
        public int IntRegionId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_gift_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_gift_id'.
        /// </value>
        public int IntGiftId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_quantity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_quantity'.
        /// </value>
        public int? IntQuantity { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_remaining'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_remaining'.
        /// </value>
        public int? IntRemaining { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_date_modify'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_date_modify'.
        /// </value>
        public long? IntDateModify { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_satus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_satus'.
        /// </value>
        public int? IntSatus { get; set; }

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
