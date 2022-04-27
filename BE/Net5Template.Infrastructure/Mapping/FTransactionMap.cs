using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.FTransaction" />
    /// </summary>
    public partial class FTransactionMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.FTransaction>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.FTransaction" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.FTransaction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FTransaction", "mobile");

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

            builder.Property(t => t.IntExchangeId)
                .HasColumnName("int_exchange_id")
                .HasColumnType("int");

            builder.Property(t => t.IntGiftId)
                .HasColumnName("int_gift_id")
                .HasColumnType("int");

            builder.Property(t => t.StrName)
                .HasColumnName("str_name")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.FCoin)
                .HasColumnName("FCoin")
                .HasColumnType("varbinary(500)")
                .HasMaxLength(500);

            builder.Property(t => t.FCoinTotal)
                .HasColumnName("FCoin_total")
                .HasColumnType("varbinary(500)")
                .HasMaxLength(500);

            builder.Property(t => t.FCoinExchangeTotal)
                .HasColumnName("FCoin_exchange_total")
                .HasColumnType("varbinary(500)")
                .HasMaxLength(500);

            builder.Property(t => t.IntChecklistDate)
                .HasColumnName("int_checklist_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntChecklistId)
                .HasColumnName("int_checklist_id")
                .HasColumnType("bigint");

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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.FTransaction" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.FTransaction" /></summary>
            public const string Name = "FTransaction";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntShopId" /></summary>
            public const string IntShopId = "int_shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntUserId" /></summary>
            public const string IntUserId = "int_user_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntExchangeId" /></summary>
            public const string IntExchangeId = "int_exchange_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntGiftId" /></summary>
            public const string IntGiftId = "int_gift_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.StrName" /></summary>
            public const string StrName = "str_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.FCoin" /></summary>
            public const string FCoin = "FCoin";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.FCoinTotal" /></summary>
            public const string FCoinTotal = "FCoin_total";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.FCoinExchangeTotal" /></summary>
            public const string FCoinExchangeTotal = "FCoin_exchange_total";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntChecklistDate" /></summary>
            public const string IntChecklistDate = "int_checklist_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntChecklistId" /></summary>
            public const string IntChecklistId = "int_checklist_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntModifyBy" /></summary>
            public const string IntModifyBy = "int_modify_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FTransaction.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
