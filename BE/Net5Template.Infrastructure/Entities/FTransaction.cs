using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'FTransaction'.
    /// </summary>
    public partial class FTransaction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FTransaction"/> class.
        /// </summary>
        public FTransaction()
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
        /// Gets or sets the property value representing column 'int_user_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_user_id'.
        /// </value>
        public int? IntUserId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_exchange_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_exchange_id'.
        /// </value>
        public int? IntExchangeId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_gift_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_gift_id'.
        /// </value>
        public int? IntGiftId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_name'.
        /// </value>
        public string StrName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FCoin'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FCoin'.
        /// </value>
        public Byte[] FCoin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FCoin_total'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FCoin_total'.
        /// </value>
        public Byte[] FCoinTotal { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FCoin_exchange_total'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FCoin_exchange_total'.
        /// </value>
        public Byte[] FCoinExchangeTotal { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_checklist_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_checklist_date'.
        /// </value>
        public long? IntChecklistDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_checklist_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_checklist_id'.
        /// </value>
        public long? IntChecklistId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_create_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_create_date'.
        /// </value>
        public long? IntCreateDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_create_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_create_by'.
        /// </value>
        public int? IntCreateBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_modify_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_modify_date'.
        /// </value>
        public long? IntModifyDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_modify_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_modify_by'.
        /// </value>
        public int? IntModifyBy { get; set; }

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
