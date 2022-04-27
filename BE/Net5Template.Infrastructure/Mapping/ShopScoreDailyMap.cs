using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.ShopScoreDaily" />
    /// </summary>
    public partial class ShopScoreDailyMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.ShopScoreDaily>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.ShopScoreDaily" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.ShopScoreDaily> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SHOP_SCORE_DAILY", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Date)
                .HasColumnName("date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntShopId)
                .HasColumnName("int_shop_id")
                .HasColumnType("int");

            builder.Property(t => t.ScoreLastDateNum)
                .HasColumnName("SCORE_LAST_DATE_NUM")
                .HasColumnType("int");

            builder.Property(t => t.ScoreOriChangeNum)
                .HasColumnName("SCORE_ORI_CHANGE_NUM")
                .HasColumnType("int");

            builder.Property(t => t.SoreNum)
                .HasColumnName("SORE_NUM")
                .HasColumnType("int");

            builder.Property(t => t.ScoreChangeNum)
                .IsRequired()
                .HasColumnName("SCORE_CHANGE_NUM")
                .HasColumnType("int");

            builder.Property(t => t.FGiftContent)
                .HasColumnName("FGift_content")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.ShopScoreDaily" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.ShopScoreDaily" /></summary>
            public const string Name = "SHOP_SCORE_DAILY";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopScoreDaily.Date" /></summary>
            public const string Date = "date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopScoreDaily.IntShopId" /></summary>
            public const string IntShopId = "int_shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopScoreDaily.ScoreLastDateNum" /></summary>
            public const string ScoreLastDateNum = "SCORE_LAST_DATE_NUM";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopScoreDaily.ScoreOriChangeNum" /></summary>
            public const string ScoreOriChangeNum = "SCORE_ORI_CHANGE_NUM";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopScoreDaily.SoreNum" /></summary>
            public const string SoreNum = "SORE_NUM";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopScoreDaily.ScoreChangeNum" /></summary>
            public const string ScoreChangeNum = "SCORE_CHANGE_NUM";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ShopScoreDaily.FGiftContent" /></summary>
            public const string FGiftContent = "FGift_content";
        }
        #endregion
    }
}
