using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.ChecklistNotes" />
    /// </summary>
    public partial class ChecklistNotesMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.ChecklistNotes>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.ChecklistNotes" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.ChecklistNotes> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChecklistNotes", "mobile");

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

            builder.Property(t => t.StrUserName)
                .HasColumnName("str_user_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StrContent)
                .HasColumnName("str_content")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            builder.Property(t => t.IntChecklistDate)
                .HasColumnName("int_checklist_date")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.ChecklistNotes" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.ChecklistNotes" /></summary>
            public const string Name = "ChecklistNotes";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistNotes.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistNotes.IntChecklistId" /></summary>
            public const string IntChecklistId = "int_checklist_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistNotes.StrUserName" /></summary>
            public const string StrUserName = "str_user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistNotes.StrContent" /></summary>
            public const string StrContent = "str_content";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistNotes.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistNotes.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistNotes.IntChecklistDate" /></summary>
            public const string IntChecklistDate = "int_checklist_date";
        }
        #endregion
    }
}
