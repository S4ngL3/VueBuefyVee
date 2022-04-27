using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.DMLifeCyclePGD" />
    /// </summary>
    public partial class DMLifeCyclePGDMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.DMLifeCyclePGD>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.DMLifeCyclePGD" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.DMLifeCyclePGD> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DM_LifeCyclePGD", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntLifecycleId)
                .HasColumnName("int_lifecycle_id")
                .HasColumnType("int");

            builder.Property(t => t.StrLifecycleName)
                .HasColumnName("str_lifecycle_name")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IntOrderBy)
                .HasColumnName("int_order_by")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.DMLifeCyclePGD" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.DMLifeCyclePGD" /></summary>
            public const string Name = "DM_LifeCyclePGD";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMLifeCyclePGD.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMLifeCyclePGD.IntLifecycleId" /></summary>
            public const string IntLifecycleId = "int_lifecycle_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMLifeCyclePGD.StrLifecycleName" /></summary>
            public const string StrLifecycleName = "str_lifecycle_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMLifeCyclePGD.IntOrderBy" /></summary>
            public const string IntOrderBy = "int_order_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMLifeCyclePGD.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
