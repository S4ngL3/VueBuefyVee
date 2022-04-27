using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Task'.
    /// </summary>
    public partial class Task
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task"/> class.
        /// </summary>
        public Task()
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
        /// Gets or sets the property value representing column 'int_schedules_time'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_schedules_time'.
        /// </value>
        public int? IntSchedulesTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_approvals'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_approvals'.
        /// </value>
        public string StrApprovals { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_parent_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_parent_id'.
        /// </value>
        public long? IntParentId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_group_task_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_group_task_id'.
        /// </value>
        public int? IntGroupTaskId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_subtask'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_subtask'.
        /// </value>
        public int? IntSubtask { get; set; }

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
        /// Gets or sets the property value representing column 'int_start_time'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_start_time'.
        /// </value>
        public int? IntStartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_end_time'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_end_time'.
        /// </value>
        public int? IntEndTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_DM_active'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_DM_active'.
        /// </value>
        public int? IntDMActive { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_category_task'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_category_task'.
        /// </value>
        public int? IntCategoryTask { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_quantity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_quantity'.
        /// </value>
        public string StrQuantity { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'attachments_required'.
        /// </summary>
        /// <value>
        /// The property value representing column 'attachments_required'.
        /// </value>
        public int? AttachmentsRequired { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'plus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'plus'.
        /// </value>
        public int? Plus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'minus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'minus'.
        /// </value>
        public int? Minus { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
