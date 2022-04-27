using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.FCoin" />
    /// </summary>
    public partial class FCoinMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.FCoin>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.FCoin" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.FCoin> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FCoin", "mobile");

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

            builder.Property(t => t.IntUserId)
                .HasColumnName("int_user_id")
                .HasColumnType("int");

            builder.Property(t => t.FCoinMember)
                .HasColumnName("FCoin")
                .HasColumnType("varbinary(500)")
                .HasMaxLength(500);

            builder.Property(t => t.FCoinExchange)
                .HasColumnName("FCoin_exchange")
                .HasColumnType("varbinary(500)")
                .HasMaxLength(500);

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntModifyDate)
                .HasColumnName("int_modify_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntStatus)
                .HasColumnName("int_status")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.FCoin" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.FCoin" /></summary>
            public const string Name = "FCoin";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.IntShopId" /></summary>
            public const string IntShopId = "int_shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.IntUserId" /></summary>
            public const string IntUserId = "int_user_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.FCoinMember" /></summary>
            public const string FCoinMember = "FCoin";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.FCoinExchange" /></summary>
            public const string FCoinExchange = "FCoin_exchange";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FCoin.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
