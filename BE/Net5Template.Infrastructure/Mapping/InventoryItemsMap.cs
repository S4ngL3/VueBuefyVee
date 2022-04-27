using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.InventoryItems" />
    /// </summary>
    public partial class InventoryItemsMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.InventoryItems>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.InventoryItems" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.InventoryItems> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("InventoryItems", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ShopId)
                .HasColumnName("shop_id")
                .HasColumnType("int");

            builder.Property(t => t.ItemsCode)
                .HasColumnName("items_code")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.QuantityReal)
                .HasColumnName("quantity_real")
                .HasColumnType("int");

            builder.Property(t => t.QuantitySystem)
                .HasColumnName("quantity_system")
                .HasColumnType("int");

            builder.Property(t => t.Explanation)
                .HasColumnName("explanation")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.InventoryMonth)
                .HasColumnName("inventory_month")
                .HasColumnType("bigint");

            builder.Property(t => t.CreateDate)
                .HasColumnName("create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.CreateBy)
                .HasColumnName("create_by")
                .HasColumnType("int");

            builder.Property(t => t.ModifyDate)
                .HasColumnName("modify_date")
                .HasColumnType("bigint");

            builder.Property(t => t.ModifyBy)
                .HasColumnName("modify_by")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.InventoryItems" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.InventoryItems" /></summary>
            public const string Name = "InventoryItems";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.ShopId" /></summary>
            public const string ShopId = "shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.ItemsCode" /></summary>
            public const string ItemsCode = "items_code";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.QuantityReal" /></summary>
            public const string QuantityReal = "quantity_real";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.QuantitySystem" /></summary>
            public const string QuantitySystem = "quantity_system";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.Explanation" /></summary>
            public const string Explanation = "explanation";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.InventoryMonth" /></summary>
            public const string InventoryMonth = "inventory_month";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.CreateDate" /></summary>
            public const string CreateDate = "create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.CreateBy" /></summary>
            public const string CreateBy = "create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.ModifyDate" /></summary>
            public const string ModifyDate = "modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.ModifyBy" /></summary>
            public const string ModifyBy = "modify_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.InventoryItems.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
