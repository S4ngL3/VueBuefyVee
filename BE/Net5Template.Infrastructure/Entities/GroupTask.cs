using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'GroupTask'.
    /// </summary>
    public partial class GroupTask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupTask"/> class.
        /// </summary>
        public GroupTask()
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
        /// Gets or sets the property value representing column 'str_code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_code'.
        /// </value>
        public string StrCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_name'.
        /// </value>
        public string StrName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_descriptions'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_descriptions'.
        /// </value>
        public string StrDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_parent_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_parent_id'.
        /// </value>
        public long? IntParentId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_group_for'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_group_for'.
        /// </value>
        public int? IntGroupFor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_region_for'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_region_for'.
        /// </value>
        public int? IntRegionFor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_object_for'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_object_for'.
        /// </value>
        public int? IntObjectFor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_active'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_active'.
        /// </value>
        public int? IntActive { get; set; }

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
        public long? IntCreateBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'state'.
        /// </summary>
        /// <value>
        /// The property value representing column 'state'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_group_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_group_by'.
        /// </value>
        public int? IntGroupBy { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
