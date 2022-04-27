using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.DMUnit" />
    /// </summary>
    public partial class DMUnitMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.DMUnit>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.DMUnit" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.DMUnit> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DM_Unit", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UnitCode)
                .HasColumnName("unit_code")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.UnitName)
                .HasColumnName("unit_name")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntCreateBy)
                .HasColumnName("int_create_by")
                .HasColumnType("int");

            builder.Property(t => t.IntModifyDate)
                .HasColumnName("int_modify_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntModifyBy)
                .HasColumnName("int_modify_by")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.DMUnit" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.DMUnit" /></summary>
            public const string Name = "DM_Unit";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMUnit.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMUnit.UnitCode" /></summary>
            public const string UnitCode = "unit_code";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMUnit.UnitName" /></summary>
            public const string UnitName = "unit_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMUnit.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMUnit.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMUnit.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMUnit.IntModifyBy" /></summary>
            public const string IntModifyBy = "int_modify_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMUnit.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
