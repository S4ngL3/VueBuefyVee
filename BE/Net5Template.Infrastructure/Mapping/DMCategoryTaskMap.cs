using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.DMCategoryTask" />
    /// </summary>
    public partial class DMCategoryTaskMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.DMCategoryTask>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.DMCategoryTask" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.DMCategoryTask> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DM_CategoryTask", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntCategoryTaskId)
                .HasColumnName("int_category_task_id")
                .HasColumnType("int");

            builder.Property(t => t.StrCategoryTaskName)
                .HasColumnName("str_category_task_name")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.DMCategoryTask" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.DMCategoryTask" /></summary>
            public const string Name = "DM_CategoryTask";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMCategoryTask.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMCategoryTask.IntCategoryTaskId" /></summary>
            public const string IntCategoryTaskId = "int_category_task_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMCategoryTask.StrCategoryTaskName" /></summary>
            public const string StrCategoryTaskName = "str_category_task_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMCategoryTask.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
