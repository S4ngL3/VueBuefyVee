using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'WorkCalendar'.
    /// </summary>
    public partial class WorkCalendar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkCalendar"/> class.
        /// </summary>
        public WorkCalendar()
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
        /// Gets or sets the property value representing column 'int_schedules_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_schedules_date'.
        /// </value>
        public long? IntSchedulesDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_schedules_time'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_schedules_time'.
        /// </value>
        public int? IntSchedulesTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_create_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_create_date'.
        /// </value>
        public long? IntCreateDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_modify_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_modify_by'.
        /// </value>
        public int? IntModifyBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_modify_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_modify_date'.
        /// </value>
        public long? IntModifyDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_session_time'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_session_time'.
        /// </value>
        public int? IntSessionTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_workplace'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_workplace'.
        /// </value>
        public int? IntWorkplace { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_color'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_color'.
        /// </value>
        public int? IntColor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_work_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_work_name'.
        /// </value>
        public string StrWorkName { get; set; }

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
