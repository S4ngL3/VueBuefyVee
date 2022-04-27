using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.GameRules" />
    /// </summary>
    public partial class GameRulesMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.GameRules>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.GameRules" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.GameRules> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("GameRules", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.StrTitle)
                .HasColumnName("str_title")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.StrContent)
                .HasColumnName("str_content")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IntValidDateFrom)
                .HasColumnName("int_valid_date_from")
                .HasColumnType("bigint");

            builder.Property(t => t.IntValidDateTo)
                .HasColumnName("int_valid_date_to")
                .HasColumnType("bigint");

            builder.Property(t => t.IntStatus)
                .HasColumnName("int_status")
                .HasColumnType("int");

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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.GameRules" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.GameRules" /></summary>
            public const string Name = "GameRules";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GameRules.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GameRules.StrTitle" /></summary>
            public const string StrTitle = "str_title";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GameRules.StrContent" /></summary>
            public const string StrContent = "str_content";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GameRules.IntValidDateFrom" /></summary>
            public const string IntValidDateFrom = "int_valid_date_from";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GameRules.IntValidDateTo" /></summary>
            public const string IntValidDateTo = "int_valid_date_to";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GameRules.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GameRules.IntSort" /></summary>
            public const string IntSort = "int_sort";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.GameRules.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
