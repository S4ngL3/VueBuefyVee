using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.CheckList" />
    /// </summary>
    public partial class CheckListMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.CheckList>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.CheckList" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.CheckList> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CheckList", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntUserId)
                .HasColumnName("int_user_id")
                .HasColumnType("int");

            builder.Property(t => t.StrUserName)
                .HasColumnName("str_user_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IntGroupFor)
                .HasColumnName("int_group_for")
                .HasColumnType("int");

            builder.Property(t => t.IntObjectFor)
                .HasColumnName("int_object_for")
                .HasColumnType("int");

            builder.Property(t => t.IntShopId)
                .HasColumnName("int_shop_id")
                .HasColumnType("int");

            builder.Property(t => t.IntGroupTaskId)
                .HasColumnName("int_group_task_id")
                .HasColumnType("int");

            builder.Property(t => t.IntParentId)
                .HasColumnName("int_parent_id")
                .HasColumnType("bigint");

            builder.Property(t => t.IntTaskId)
                .HasColumnName("int_task_id")
                .HasColumnType("bigint");

            builder.Property(t => t.StrTaskName)
                .HasColumnName("str_task_name")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.StrTaskDescriptions)
                .HasColumnName("str_task_descriptions")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IntDone)
                .HasColumnName("int_done")
                .HasColumnType("int");

            builder.Property(t => t.IntSchedulesTime)
                .HasColumnName("int_schedules_time")
                .HasColumnType("int");

            builder.Property(t => t.IntCheckBy)
                .HasColumnName("int_check_by")
                .HasColumnType("int");

            builder.Property(t => t.IntCheckDate)
                .HasColumnName("int_check_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntModifyDate)
                .HasColumnName("int_modify_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntModifyBy)
                .HasColumnName("int_modify_by")
                .HasColumnType("int");

            builder.Property(t => t.IntChecklistDate)
                .HasColumnName("int_checklist_date")
                .HasColumnType("bigint");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            builder.Property(t => t.IntCreateBy)
                .HasColumnName("int_create_by")
                .HasColumnType("int");

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntStartTime)
                .HasColumnName("int_start_time")
                .HasColumnType("int");

            builder.Property(t => t.IntEndTime)
                .HasColumnName("int_end_time")
                .HasColumnType("int");

            builder.Property(t => t.IntDMActive)
                .HasColumnName("int_DM_active")
                .HasColumnType("int");

            builder.Property(t => t.IntCategoryTask)
                .HasColumnName("int_category_task")
                .HasColumnType("int");

            builder.Property(t => t.StrQuantity)
                .HasColumnName("str_quantity")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.CheckList" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.CheckList" /></summary>
            public const string Name = "CheckList";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntUserId" /></summary>
            public const string IntUserId = "int_user_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.StrUserName" /></summary>
            public const string StrUserName = "str_user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntGroupFor" /></summary>
            public const string IntGroupFor = "int_group_for";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntObjectFor" /></summary>
            public const string IntObjectFor = "int_object_for";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntShopId" /></summary>
            public const string IntShopId = "int_shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntGroupTaskId" /></summary>
            public const string IntGroupTaskId = "int_group_task_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntParentId" /></summary>
            public const string IntParentId = "int_parent_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntTaskId" /></summary>
            public const string IntTaskId = "int_task_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.StrTaskName" /></summary>
            public const string StrTaskName = "str_task_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.StrTaskDescriptions" /></summary>
            public const string StrTaskDescriptions = "str_task_descriptions";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntDone" /></summary>
            public const string IntDone = "int_done";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntSchedulesTime" /></summary>
            public const string IntSchedulesTime = "int_schedules_time";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntCheckBy" /></summary>
            public const string IntCheckBy = "int_check_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntCheckDate" /></summary>
            public const string IntCheckDate = "int_check_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntModifyBy" /></summary>
            public const string IntModifyBy = "int_modify_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntChecklistDate" /></summary>
            public const string IntChecklistDate = "int_checklist_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntStartTime" /></summary>
            public const string IntStartTime = "int_start_time";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntEndTime" /></summary>
            public const string IntEndTime = "int_end_time";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntDMActive" /></summary>
            public const string IntDMActive = "int_DM_active";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.IntCategoryTask" /></summary>
            public const string IntCategoryTask = "int_category_task";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.CheckList.StrQuantity" /></summary>
            public const string StrQuantity = "str_quantity";
        }
        #endregion
    }
}
