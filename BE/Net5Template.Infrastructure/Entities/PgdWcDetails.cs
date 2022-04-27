using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PgdWcDetails'.
    /// </summary>
    public partial class PgdWcDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PgdWcDetails"/> class.
        /// </summary>
        public PgdWcDetails()
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
        /// Gets or sets the property value representing column 'lock_date_from'.
        /// </summary>
        /// <value>
        /// The property value representing column 'lock_date_from'.
        /// </value>
        public string LockDateFrom { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'lock_date_to'.
        /// </summary>
        /// <value>
        /// The property value representing column 'lock_date_to'.
        /// </value>
        public string LockDateTo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_status'.
        /// </value>
        public int? IntStatus { get; set; }

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
