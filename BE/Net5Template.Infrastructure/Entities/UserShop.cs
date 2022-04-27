using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'User_Shop'.
    /// </summary>
    public partial class UserShop
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserShop"/> class.
        /// </summary>
        public UserShop()
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
        /// Gets or sets the property value representing column 'user_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'user_id'.
        /// </value>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'user_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'user_name'.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'user_full_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'user_full_name'.
        /// </value>
        public string UserFullName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'position'.
        /// </summary>
        /// <value>
        /// The property value representing column 'position'.
        /// </value>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'shop_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'shop_id'.
        /// </value>
        public int? ShopId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'shop_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'shop_name'.
        /// </value>
        public string ShopName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'user_position'.
        /// </summary>
        /// <value>
        /// The property value representing column 'user_position'.
        /// </value>
        public int? UserPosition { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'state'.
        /// </summary>
        /// <value>
        /// The property value representing column 'state'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_status'.
        /// </value>
        public int? IntStatus { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
