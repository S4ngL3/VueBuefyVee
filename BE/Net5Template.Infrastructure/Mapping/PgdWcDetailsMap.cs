using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.PgdWcDetails" />
    /// </summary>
    public partial class PgdWcDetailsMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.PgdWcDetails>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.PgdWcDetails" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.PgdWcDetails> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PgdWcDetails", "mobile");

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

            builder.Property(t => t.LockDateFrom)
                .HasColumnName("lock_date_from")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LockDateTo)
                .HasColumnName("lock_date_to")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.PgdWcDetails" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.PgdWcDetails" /></summary>
            public const string Name = "PgdWcDetails";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWcDetails.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWcDetails.ShopId" /></summary>
            public const string ShopId = "shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWcDetails.LockDateFrom" /></summary>
            public const string LockDateFrom = "lock_date_from";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWcDetails.LockDateTo" /></summary>
            public const string LockDateTo = "lock_date_to";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWcDetails.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWcDetails.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
