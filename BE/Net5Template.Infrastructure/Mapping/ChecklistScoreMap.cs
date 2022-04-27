using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.ChecklistScore" />
    /// </summary>
    public partial class ChecklistScoreMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.ChecklistScore>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.ChecklistScore" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.ChecklistScore> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("CHECKLIST_SCORE", "dbo");

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

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.ChecklistScore" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.ChecklistScore" /></summary>
            public const string Name = "CHECKLIST_SCORE";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistScore.Date" /></summary>
            public const string Date = "date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistScore.IntShopId" /></summary>
            public const string IntShopId = "int_shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistScore.ScoreLastDateNum" /></summary>
            public const string ScoreLastDateNum = "SCORE_LAST_DATE_NUM";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistScore.ScoreOriChangeNum" /></summary>
            public const string ScoreOriChangeNum = "SCORE_ORI_CHANGE_NUM";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistScore.SoreNum" /></summary>
            public const string SoreNum = "SORE_NUM";
        }
        #endregion
    }
}
