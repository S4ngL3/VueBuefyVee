using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'NotifyRealtime'.
    /// </summary>
    public partial class NotifyRealtime
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyRealtime"/> class.
        /// </summary>
        public NotifyRealtime()
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
        /// Gets or sets the property value representing column 'int_user_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_user_id'.
        /// </value>
        public int? IntUserId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_user_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_user_name'.
        /// </value>
        public string StrUserName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_code'.
        /// </value>
        public string StrCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_title'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_title'.
        /// </value>
        public string StrTitle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_content'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_content'.
        /// </value>
        public string StrContent { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_content_old'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_content_old'.
        /// </value>
        public string StrContentOld { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_content_new'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_content_new'.
        /// </value>
        public string StrContentNew { get; set; }

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

        /// <summary>
        /// Gets or sets the property value representing column 'int_create_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_create_date'.
        /// </value>
        public long? IntCreateDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_user_id_update_wc'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_user_id_update_wc'.
        /// </value>
        public int? IntUserIdUpdateWc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_user_name_update_wc'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_user_name_update_wc'.
        /// </value>
        public string StrUserNameUpdateWc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'session_key'.
        /// </summary>
        /// <value>
        /// The property value representing column 'session_key'.
        /// </value>
        public long? SessionKey { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
