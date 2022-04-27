using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.HistoryImportFile" />
    /// </summary>
    public partial class HistoryImportFileMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.HistoryImportFile>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.HistoryImportFile" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.HistoryImportFile> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("History_ImportFile", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Path)
                .HasColumnName("path")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Capacity)
                .HasColumnName("capacity")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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

            builder.Property(t => t.IntRowSuccess)
                .HasColumnName("int_row_success")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.HistoryImportFile" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.HistoryImportFile" /></summary>
            public const string Name = "History_ImportFile";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.Path" /></summary>
            public const string Path = "path";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.Capacity" /></summary>
            public const string Capacity = "capacity";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.IntModifyBy" /></summary>
            public const string IntModifyBy = "int_modify_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.IntRowSuccess" /></summary>
            public const string IntRowSuccess = "int_row_success";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.HistoryImportFile.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
