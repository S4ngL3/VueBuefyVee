using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'GameRules'.
    /// </summary>
    public partial class GameRules
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameRules"/> class.
        /// </summary>
        public GameRules()
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
        /// Gets or sets the property value representing column 'int_valid_date_from'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_valid_date_from'.
        /// </value>
        public long? IntValidDateFrom { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_valid_date_to'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_valid_date_to'.
        /// </value>
        public long? IntValidDateTo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_status'.
        /// </value>
        public int? IntStatus { get; set; }

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
