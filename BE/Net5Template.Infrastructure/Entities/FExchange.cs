using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'FExchange'.
    /// </summary>
    public partial class FExchange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FExchange"/> class.
        /// </summary>
        public FExchange()
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
        /// Gets or sets the property value representing column 'int_exchange_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_exchange_id'.
        /// </value>
        public int? IntExchangeId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FExchange_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FExchange_name'.
        /// </value>
        public string FExchangeName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FCoin'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FCoin'.
        /// </value>
        public Byte[] FCoin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_status'.
        /// </value>
        public int? IntStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_url'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_url'.
        /// </value>
        public string StrUrl { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_quantity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_quantity'.
        /// </value>
        public int? IntQuantity { get; set; }

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
