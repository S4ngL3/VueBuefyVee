using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.ShopOpen" />
    /// </summary>
    public partial class ShopOpenMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.ShopOpen>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.ShopOpen" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.ShopOpen> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Shop_Open", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntShopId)
                .HasColumnName("int_shop_id")
                .HasColumnType("int");

            builder.Property(t => t.StrCode)
                .HasColumnName("str_code")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.OpenDate)
                .HasColumnName("open_date")
                .HasColumnType("bigint");

            builder.Property(t => t.StrName)
                .HasColumnName("str_name")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.AreaId)
                .HasColumnName("area_id")
                .HasColumnType("int");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            builder.Property(t => t.OpenDateCustomization)
                .HasColumnName("open_date_customization")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.ShopOpen" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.ShopOpen" /></summary>
            public const string Name = "Shop_Open";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopOpen.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopOpen.IntShopId" /></summary>
            public const string IntShopId = "int_shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopOpen.StrCode" /></summary>
            public const string StrCode = "str_code";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopOpen.OpenDate" /></summary>
            public const string OpenDate = "open_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopOpen.StrName" /></summary>
            public const string StrName = "str_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopOpen.AreaId" /></summary>
            public const string AreaId = "area_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopOpen.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopOpen.OpenDateCustomization" /></summary>
            public const string OpenDateCustomization = "open_date_customization";
        }
        #endregion
    }
}
