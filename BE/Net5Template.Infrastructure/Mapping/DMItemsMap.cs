using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.DMItems" />
    /// </summary>
    public partial class DMItemsMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.DMItems>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.DMItems" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.DMItems> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DM_Items", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ItemsCode)
                .HasColumnName("items_code")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ItemsName)
                .HasColumnName("items_name")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.Descriptions)
                .HasColumnName("descriptions")
                .HasColumnType("nvarchar(max)");

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

            builder.Property(t => t.IntDMUnitId)
                .HasColumnName("int_DM_unit_id")
                .HasColumnType("bigint");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.DMItems" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.DMItems" /></summary>
            public const string Name = "DM_Items";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.ItemsCode" /></summary>
            public const string ItemsCode = "items_code";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.ItemsName" /></summary>
            public const string ItemsName = "items_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.Descriptions" /></summary>
            public const string Descriptions = "descriptions";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.IntModifyBy" /></summary>
            public const string IntModifyBy = "int_modify_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.IntDMUnitId" /></summary>
            public const string IntDMUnitId = "int_DM_unit_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMItems.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
