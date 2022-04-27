using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.ChecklistFile" />
    /// </summary>
    public partial class ChecklistFileMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.ChecklistFile>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.ChecklistFile" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.ChecklistFile> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChecklistFile", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntChecklistId)
                .HasColumnName("int_checklist_id")
                .HasColumnType("bigint");

            builder.Property(t => t.StrName)
                .HasColumnName("str_name")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.StrPath)
                .HasColumnName("str_path")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IntStatus)
                .HasColumnName("int_status")
                .HasColumnType("int");

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntModifyDate)
                .HasColumnName("int_modify_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntCreateBy)
                .HasColumnName("int_create_by")
                .HasColumnType("int");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            builder.Property(t => t.IntChecklistDate)
                .HasColumnName("int_checklist_date")
                .HasColumnType("bigint");

            builder.Property(t => t.StrUserName)
                .HasColumnName("str_user_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IntLat)
                .HasColumnName("int_lat")
                .HasColumnType("float");

            builder.Property(t => t.IntLong)
                .HasColumnName("int_long")
                .HasColumnType("float");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.ChecklistFile" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.ChecklistFile" /></summary>
            public const string Name = "ChecklistFile";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.IntChecklistId" /></summary>
            public const string IntChecklistId = "int_checklist_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.StrName" /></summary>
            public const string StrName = "str_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.StrPath" /></summary>
            public const string StrPath = "str_path";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.IntChecklistDate" /></summary>
            public const string IntChecklistDate = "int_checklist_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.StrUserName" /></summary>
            public const string StrUserName = "str_user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.IntLat" /></summary>
            public const string IntLat = "int_lat";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistFile.IntLong" /></summary>
            public const string IntLong = "int_long";
        }
        #endregion
    }
}
