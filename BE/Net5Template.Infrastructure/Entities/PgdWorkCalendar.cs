using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PgdWorkCalendar'.
    /// </summary>
    public partial class PgdWorkCalendar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PgdWorkCalendar"/> class.
        /// </summary>
        public PgdWorkCalendar()
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
        /// Gets or sets the property value representing column 'int_shop_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_shop_id'.
        /// </value>
        public int? IntShopId { get; set; }

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
        /// Gets or sets the property value representing column 'user_full_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'user_full_name'.
        /// </value>
        public string UserFullName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_schedules_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_schedules_date'.
        /// </value>
        public long? IntSchedulesDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_shifts_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_shifts_id'.
        /// </value>
        public int? IntShiftsId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_create_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_create_by'.
        /// </value>
        public int? IntCreateBy { get; set; }

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
