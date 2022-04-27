using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'CheckList'.
    /// </summary>
    public partial class CheckList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckList"/> class.
        /// </summary>
        public CheckList()
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
        /// Gets or sets the property value representing column 'int_group_for'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_group_for'.
        /// </value>
        public int? IntGroupFor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_object_for'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_object_for'.
        /// </value>
        public int? IntObjectFor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_shop_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_shop_id'.
        /// </value>
        public int? IntShopId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_group_task_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_group_task_id'.
        /// </value>
        public int? IntGroupTaskId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_parent_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_parent_id'.
        /// </value>
        public long? IntParentId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_task_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_task_id'.
        /// </value>
        public long? IntTaskId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_task_name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_task_name'.
        /// </value>
        public string StrTaskName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'str_task_descriptions'.
        /// </summary>
        /// <value>
        /// The property value representing column 'str_task_descriptions'.
        /// </value>
        public string StrTaskDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_done'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_done'.
        /// </value>
        public int? IntDone { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_schedules_time'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_schedules_time'.
        /// </value>
        public int? IntSchedulesTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_check_by'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_check_by'.
        /// </value>
        public int? IntCheckBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_check_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_check_date'.
        /// </value>
        public long? IntCheckDate { get; set; }

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
        /// Gets or sets the property value representing column 'int_checklist_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_checklist_date'.
        /// </value>
        public long? IntChecklistDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'state'.
        /// </summary>
        /// <value>
        /// The property value representing column 'state'.
        /// </value>
        public int? State { get; set; }

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

        #endregion

        #region Generated Relationships
        #endregion

    }
}
