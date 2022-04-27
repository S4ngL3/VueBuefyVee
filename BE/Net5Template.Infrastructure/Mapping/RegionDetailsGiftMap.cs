using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.RegionDetailsGift" />
    /// </summary>
    public partial class RegionDetailsGiftMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.RegionDetailsGift>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.RegionDetailsGift" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.RegionDetailsGift> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("RegionDetailsGift", "mobile");

            // key
            builder.HasKey(t => new { t.IntRegionId, t.IntGiftId });

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntRegionId)
                .IsRequired()
                .HasColumnName("int_region_id")
                .HasColumnType("int");

            builder.Property(t => t.IntGiftId)
                .IsRequired()
                .HasColumnName("int_gift_id")
                .HasColumnType("int");

            builder.Property(t => t.IntQuantity)
                .HasColumnName("int_quantity")
                .HasColumnType("int");

            builder.Property(t => t.IntRemaining)
                .HasColumnName("int_remaining")
                .HasColumnType("int");

            builder.Property(t => t.IntDateModify)
                .HasColumnName("int_date_modify")
                .HasColumnType("bigint");

            builder.Property(t => t.IntSatus)
                .HasColumnName("int_satus")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.RegionDetailsGift" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.RegionDetailsGift" /></summary>
            public const string Name = "RegionDetailsGift";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.RegionDetailsGift.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.RegionDetailsGift.IntRegionId" /></summary>
            public const string IntRegionId = "int_region_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.RegionDetailsGift.IntGiftId" /></summary>
            public const string IntGiftId = "int_gift_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.RegionDetailsGift.IntQuantity" /></summary>
            public const string IntQuantity = "int_quantity";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.RegionDetailsGift.IntRemaining" /></summary>
            public const string IntRemaining = "int_remaining";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.RegionDetailsGift.IntDateModify" /></summary>
            public const string IntDateModify = "int_date_modify";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.RegionDetailsGift.IntSatus" /></summary>
            public const string IntSatus = "int_satus";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.RegionDetailsGift.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
