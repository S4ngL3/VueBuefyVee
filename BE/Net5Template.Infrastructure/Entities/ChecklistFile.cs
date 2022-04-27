using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ChecklistFile'.
    /// </summary>
    public partial class ChecklistFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistFile"/> class.
        /// </summary>
        public ChecklistFile()
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
        /// Gets or sets the property value representing column 'int_checklist_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_checklist_id'.
        /// </value>
        public long? IntChecklistId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_name'.
        /// </value>
        public string StrName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_path'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_path'.
        /// </value>
        public string StrPath { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_status'.
        /// </value>
        public int? IntStatus { get; set; }

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
        /// Gets or sets the property value representing column 'int_create_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_create_by'.
        /// </value>
        public int? IntCreateBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'state'.
        /// </summary>
        /// <value>
        /// The property value representing column 'state'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_checklist_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_checklist_date'.
        /// </value>
        public long? IntChecklistDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_user_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_user_name'.
        /// </value>
        public string StrUserName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_lat'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_lat'.
        /// </value>
        public double? IntLat { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_long'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_long'.
        /// </value>
        public double? IntLong { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
