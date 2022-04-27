using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Shifts'.
    /// </summary>
    public partial class Shifts
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shifts"/> class.
        /// </summary>
        public Shifts()
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
        /// Gets or sets the property value representing column 'int_shifts_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_shifts_id'.
        /// </value>
        public int? IntShiftsId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_shifts_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_shifts_name'.
        /// </value>
        public string StrShiftsName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_time_from'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_time_from'.
        /// </value>
        public string IntTimeFrom { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_time_to'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_time_to'.
        /// </value>
        public string IntTimeTo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_notes'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_notes'.
        /// </value>
        public string StrNotes { get; set; }

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

        #endregion

        #region Generated Relationships
        #endregion

    }
}
