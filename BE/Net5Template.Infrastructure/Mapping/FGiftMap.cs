using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.FGift" />
    /// </summary>
    public partial class FGiftMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.FGift>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.FGift" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.FGift> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FGift", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntGiftId)
                .HasColumnName("int_gift_id")
                .HasColumnType("int");

            builder.Property(t => t.FGiftTitle)
                .HasColumnName("FGift_title")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.FGiftContent)
                .HasColumnName("FGift_content")
                .HasColumnType("nvarchar(max)");

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

            builder.Property(t => t.IntSort)
                .HasColumnName("int_sort")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.FGift" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.FGift" /></summary>
            public const string Name = "FGift";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.IntGiftId" /></summary>
            public const string IntGiftId = "int_gift_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.FGiftTitle" /></summary>
            public const string FGiftTitle = "FGift_title";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.FGiftContent" /></summary>
            public const string FGiftContent = "FGift_content";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.FCoin" /></summary>
            public const string FCoin = "FCoin";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.StrUrl" /></summary>
            public const string StrUrl = "str_url";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.IntSort" /></summary>
            public const string IntSort = "int_sort";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.FGift.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
