using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'DM_Items'.
    /// </summary>
    public partial class DMItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMItems"/> class.
        /// </summary>
        public DMItems()
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
        /// Gets or sets the property value representing column 'items_code'.
        /// </summary>
        /// <value>
        /// The property value representing column 'items_code'.
        /// </value>
        public string ItemsCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'items_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'items_name'.
        /// </value>
        public string ItemsName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'descriptions'.
        /// </summary>
        /// <value>
        /// The property value representing column 'descriptions'.
        /// </value>
        public string Descriptions { get; set; }

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
        /// Gets or sets the property value representing column 'int_DM_unit_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_DM_unit_id'.
        /// </value>
        public long? IntDMUnitId { get; set; }

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
