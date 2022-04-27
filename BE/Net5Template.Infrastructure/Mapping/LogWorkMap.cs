using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.LogWork" />
    /// </summary>
    public partial class LogWorkMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.LogWork>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.LogWork" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.LogWork> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("LogWork", "mobile");

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
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.LogWork" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.LogWork" /></summary>
            public const string Name = "LogWork";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LogWork.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LogWork.IntChecklistId" /></summary>
            public const string IntChecklistId = "int_checklist_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LogWork.StrUserName" /></summary>
            public const string StrUserName = "str_user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LogWork.StrContent" /></summary>
            public const string StrContent = "str_content";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LogWork.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.LogWork.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
