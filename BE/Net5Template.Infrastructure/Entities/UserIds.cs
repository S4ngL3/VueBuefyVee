using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'UserIds'.
    /// </summary>
    public partial class UserIds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIds"/> class.
        /// </summary>
        public UserIds()
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
        /// Gets or sets the property value representing column 'str_user_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_user_name'.
        /// </value>
        public string StrUserName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_device_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_device_id'.
        /// </value>
        public string StrDeviceId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_fcm_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_fcm_id'.
        /// </value>
        public string StrFcmId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_create_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_create_date'.
        /// </value>
        public long? IntCreateDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_modify_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_modify_date'.
        /// </value>
        public long? IntModifyDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_status'.
        /// </value>
        public int? IntStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_type'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_type'.
        /// </value>
        public int? IntType { get; set; }

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
