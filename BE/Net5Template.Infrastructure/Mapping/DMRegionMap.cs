using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.DMRegion" />
    /// </summary>
    public partial class DMRegionMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.DMRegion>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.DMRegion" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.DMRegion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DM_Region", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntRegionId)
                .HasColumnName("int_region_id")
                .HasColumnType("int");

            builder.Property(t => t.StrRegionName)
                .HasColumnName("str_region_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            builder.Property(t => t.Color)
                .HasColumnName("color")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.DMRegion" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.DMRegion" /></summary>
            public const string Name = "DM_Region";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMRegion.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMRegion.IntRegionId" /></summary>
            public const string IntRegionId = "int_region_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMRegion.StrRegionName" /></summary>
            public const string StrRegionName = "str_region_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMRegion.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMRegion.Color" /></summary>
            public const string Color = "color";
        }
        #endregion
    }
}
