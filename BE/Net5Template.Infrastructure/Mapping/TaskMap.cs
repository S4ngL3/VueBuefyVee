using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.Task" />
    /// </summary>
    public partial class TaskMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.Task>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.Task" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.Task> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Task", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.StrCode)
                .HasColumnName("str_code")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StrName)
                .HasColumnName("str_name")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.StrDescriptions)
                .HasColumnName("str_descriptions")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IntSchedulesTime)
                .HasColumnName("int_schedules_time")
                .HasColumnType("int");

            builder.Property(t => t.StrApprovals)
                .HasColumnName("str_approvals")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.IntParentId)
                .HasColumnName("int_parent_id")
                .HasColumnType("bigint");

            builder.Property(t => t.IntGroupTaskId)
                .HasColumnName("int_group_task_id")
                .HasColumnType("int");

            builder.Property(t => t.IntSubtask)
                .HasColumnName("int_subtask")
                .HasColumnType("int");

            builder.Property(t => t.IntActive)
                .HasColumnName("int_active")
                .HasColumnType("int");

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntModifyDate)
                .HasColumnName("int_modify_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntCreateBy)
                .HasColumnName("int_create_by")
                .HasColumnType("bigint");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

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

            builder.Property(t => t.AttachmentsRequired)
                .HasColumnName("attachments_required")
                .HasColumnType("int");

            builder.Property(t => t.Plus)
                .HasColumnName("plus")
                .HasColumnType("int");

            builder.Property(t => t.Minus)
                .HasColumnName("minus")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.Task" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.Task" /></summary>
            public const string Name = "Task";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.StrCode" /></summary>
            public const string StrCode = "str_code";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.StrName" /></summary>
            public const string StrName = "str_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.StrDescriptions" /></summary>
            public const string StrDescriptions = "str_descriptions";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntSchedulesTime" /></summary>
            public const string IntSchedulesTime = "int_schedules_time";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.StrApprovals" /></summary>
            public const string StrApprovals = "str_approvals";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntParentId" /></summary>
            public const string IntParentId = "int_parent_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntGroupTaskId" /></summary>
            public const string IntGroupTaskId = "int_group_task_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntSubtask" /></summary>
            public const string IntSubtask = "int_subtask";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntActive" /></summary>
            public const string IntActive = "int_active";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntStartTime" /></summary>
            public const string IntStartTime = "int_start_time";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntEndTime" /></summary>
            public const string IntEndTime = "int_end_time";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntDMActive" /></summary>
            public const string IntDMActive = "int_DM_active";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.IntCategoryTask" /></summary>
            public const string IntCategoryTask = "int_category_task";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.StrQuantity" /></summary>
            public const string StrQuantity = "str_quantity";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.AttachmentsRequired" /></summary>
            public const string AttachmentsRequired = "attachments_required";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.Plus" /></summary>
            public const string Plus = "plus";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Task.Minus" /></summary>
            public const string Minus = "minus";
        }
        #endregion
    }
}
