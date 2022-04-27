using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'History_ImportFile'.
    /// </summary>
    public partial class HistoryImportFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryImportFile"/> class.
        /// </summary>
        public HistoryImportFile()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Id'.
        /// </value>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'path'.
        /// </summary>
        /// <value>
        /// The property value representing column 'path'.
        /// </value>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'capacity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'capacity'.
        /// </value>
        public string Capacity { get; set; }

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
        /// Gets or sets the property value representing column 'int_row_success'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_row_success'.
        /// </value>
        public int? IntRowSuccess { get; set; }

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
