using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask" />
    /// </summary>
    public partial class LifeCycleDetailsTaskMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.LifeCycleDetailsTask>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.LifeCycleDetailsTask> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("LifeCycleDetailsTask", "mobile");

            // key
            builder.HasKey(t => new { t.IntLifecycleId, t.IntTaskId, t.IntRegionId });

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntLifecycleId)
                .IsRequired()
                .HasColumnName("int_lifecycle_id")
                .HasColumnType("bigint");

            builder.Property(t => t.IntTaskId)
                .IsRequired()
                .HasColumnName("int_task_id")
                .HasColumnType("bigint");

            builder.Property(t => t.IntRegionId)
                .IsRequired()
                .HasColumnName("int_region_id")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask" /></summary>
            public const string Name = "LifeCycleDetailsTask";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask.IntLifecycleId" /></summary>
            public const string IntLifecycleId = "int_lifecycle_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask.IntTaskId" /></summary>
            public const string IntTaskId = "int_task_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask.IntRegionId" /></summary>
            public const string IntRegionId = "int_region_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LifeCycleDetailsTask.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
