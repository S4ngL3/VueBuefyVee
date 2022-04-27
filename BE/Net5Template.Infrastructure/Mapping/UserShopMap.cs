using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.UserShop" />
    /// </summary>
    public partial class UserShopMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.UserShop>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.UserShop" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.UserShop> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("User_Shop", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserId)
                .HasColumnName("user_id")
                .HasColumnType("int");

            builder.Property(t => t.UserName)
                .HasColumnName("user_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.UserFullName)
                .HasColumnName("user_full_name")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Position)
                .HasColumnName("position")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.ShopId)
                .HasColumnName("shop_id")
                .HasColumnType("int");

            builder.Property(t => t.ShopName)
                .HasColumnName("shop_name")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.UserPosition)
                .HasColumnName("user_position")
                .HasColumnType("int");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            builder.Property(t => t.IntStatus)
                .HasColumnName("int_status")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.UserShop" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.UserShop" /></summary>
            public const string Name = "User_Shop";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.UserId" /></summary>
            public const string UserId = "user_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.UserName" /></summary>
            public const string UserName = "user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.UserFullName" /></summary>
            public const string UserFullName = "user_full_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.Position" /></summary>
            public const string Position = "position";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.ShopId" /></summary>
            public const string ShopId = "shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.ShopName" /></summary>
            public const string ShopName = "shop_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.UserPosition" /></summary>
            public const string UserPosition = "user_position";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserShop.IntStatus" /></summary>
            public const string IntStatus = "int_status";
        }
        #endregion
    }
}
