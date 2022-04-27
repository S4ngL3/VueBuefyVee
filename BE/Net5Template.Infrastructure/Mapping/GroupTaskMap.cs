using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.GroupTask" />
    /// </summary>
    public partial class GroupTaskMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.GroupTask>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.GroupTask" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.GroupTask> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("GroupTask", "mobile");

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
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(t => t.StrDescriptions)
                .HasColumnName("str_descriptions")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IntParentId)
                .HasColumnName("int_parent_id")
                .HasColumnType("bigint");

            builder.Property(t => t.IntGroupFor)
                .HasColumnName("int_group_for")
                .HasColumnType("int");

            builder.Property(t => t.IntRegionFor)
                .HasColumnName("int_region_for")
                .HasColumnType("int");

            builder.Property(t => t.IntObjectFor)
                .HasColumnName("int_object_for")
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

            builder.Property(t => t.IntGroupBy)
                .HasColumnName("int_group_by")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.GroupTask" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.GroupTask" /></summary>
            public const string Name = "GroupTask";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.StrCode" /></summary>
            public const string StrCode = "str_code";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.StrName" /></summary>
            public const string StrName = "str_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.StrDescriptions" /></summary>
            public const string StrDescriptions = "str_descriptions";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntParentId" /></summary>
            public const string IntParentId = "int_parent_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntGroupFor" /></summary>
            public const string IntGroupFor = "int_group_for";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntRegionFor" /></summary>
            public const string IntRegionFor = "int_region_for";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntObjectFor" /></summary>
            public const string IntObjectFor = "int_object_for";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntActive" /></summary>
            public const string IntActive = "int_active";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GroupTask.IntGroupBy" /></summary>
            public const string IntGroupBy = "int_group_by";
        }
        #endregion
    }
}
