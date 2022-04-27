using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.FExchange" />
    /// </summary>
    public partial class FExchangeMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.FExchange>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.FExchange" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.FExchange> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FExchange", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntExchangeId)
                .HasColumnName("int_exchange_id")
                .HasColumnType("int");

            builder.Property(t => t.FExchangeName)
                .HasColumnName("FExchange_name")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.FCoin)
                .HasColumnName("FCoin")
                .HasColumnType("varbinary(500)")
                .HasMaxLength(500);

            builder.Property(t => t.IntStatus)
                .HasColumnName("int_status")
                .HasColumnType("int");

            builder.Property(t => t.StrUrl)
                .HasColumnName("str_url")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.IntQuantity)
                .HasColumnName("int_quantity")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.FExchange" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.FExchange" /></summary>
            public const string Name = "FExchange";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FExchange.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FExchange.IntExchangeId" /></summary>
            public const string IntExchangeId = "int_exchange_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FExchange.FExchangeName" /></summary>
            public const string FExchangeName = "FExchange_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FExchange.FCoin" /></summary>
            public const string FCoin = "FCoin";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FExchange.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FExchange.StrUrl" /></summary>
            public const string StrUrl = "str_url";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FExchange.IntQuantity" /></summary>
            public const string IntQuantity = "int_quantity";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FExchange.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
