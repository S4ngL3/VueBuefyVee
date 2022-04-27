using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.TaskDetailsQuantity" />
    /// </summary>
    public partial class TaskDetailsQuantityMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.TaskDetailsQuantity>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.TaskDetailsQuantity" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.TaskDetailsQuantity> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("TaskDetailsQuantity", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntTaskId)
                .HasColumnName("int_task_id")
                .HasColumnType("bigint");

            builder.Property(t => t.StrQuantity)
                .HasColumnName("str_quantity")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.IntLifecycleId)
                .HasColumnName("int_lifecycle_id")
                .HasColumnType("int");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.TaskDetailsQuantity" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.TaskDetailsQuantity" /></summary>
            public const string Name = "TaskDetailsQuantity";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.TaskDetailsQuantity.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.TaskDetailsQuantity.IntTaskId" /></summary>
            public const string IntTaskId = "int_task_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.TaskDetailsQuantity.StrQuantity" /></summary>
            public const string StrQuantity = "str_quantity";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.TaskDetailsQuantity.IntLifecycleId" /></summary>
            public const string IntLifecycleId = "int_lifecycle_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.TaskDetailsQuantity.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
