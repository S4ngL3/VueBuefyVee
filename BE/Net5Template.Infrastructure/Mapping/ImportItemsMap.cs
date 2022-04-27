using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.ImportItems" />
    /// </summary>
    public partial class ImportItemsMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.ImportItems>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.ImportItems" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.ImportItems> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ImportItems", "mobile");

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

            builder.Property(t => t.Quantity)
                .HasColumnName("quantity")
                .HasColumnType("int");

            builder.Property(t => t.CreateDate)
                .HasColumnName("create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.CreateBy)
                .HasColumnName("create_by")
                .HasColumnType("int");

            builder.Property(t => t.ImportMonth)
                .HasColumnName("import_month")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.ImportItems" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.ImportItems" /></summary>
            public const string Name = "ImportItems";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ImportItems.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ImportItems.ShopId" /></summary>
            public const string ShopId = "shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ImportItems.ItemsCode" /></summary>
            public const string ItemsCode = "items_code";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ImportItems.Quantity" /></summary>
            public const string Quantity = "quantity";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ImportItems.CreateDate" /></summary>
            public const string CreateDate = "create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ImportItems.CreateBy" /></summary>
            public const string CreateBy = "create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ImportItems.ImportMonth" /></summary>
            public const string ImportMonth = "import_month";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ImportItems.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
