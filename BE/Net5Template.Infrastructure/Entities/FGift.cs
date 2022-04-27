using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'FGift'.
    /// </summary>
    public partial class FGift
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FGift"/> class.
        /// </summary>
        public FGift()
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
        /// Gets or sets the property value representing column 'int_gift_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_gift_id'.
        /// </value>
        public int? IntGiftId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FGift_title'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FGift_title'.
        /// </value>
        public string FGiftTitle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FGift_content'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FGift_content'.
        /// </value>
        public string FGiftContent { get; set; }

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
        /// Gets or sets the property value representing column 'int_sort'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_sort'.
        /// </value>
        public int? IntSort { get; set; }

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
