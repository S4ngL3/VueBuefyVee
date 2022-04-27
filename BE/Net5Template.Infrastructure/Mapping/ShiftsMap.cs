using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.Shifts" />
    /// </summary>
    public partial class ShiftsMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.Shifts>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.Shifts" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.Shifts> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Shifts", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntShiftsId)
                .HasColumnName("int_shifts_id")
                .HasColumnType("int");

            builder.Property(t => t.StrShiftsName)
                .HasColumnName("str_shifts_name")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.IntTimeFrom)
                .HasColumnName("int_time_from")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.IntTimeTo)
                .HasColumnName("int_time_to")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.StrNotes)
                .HasColumnName("str_notes")
                .HasColumnType("nvarchar(max)");

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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.Shifts" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.Shifts" /></summary>
            public const string Name = "Shifts";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Shifts.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Shifts.IntShiftsId" /></summary>
            public const string IntShiftsId = "int_shifts_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Shifts.StrShiftsName" /></summary>
            public const string StrShiftsName = "str_shifts_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Shifts.IntTimeFrom" /></summary>
            public const string IntTimeFrom = "int_time_from";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Shifts.IntTimeTo" /></summary>
            public const string IntTimeTo = "int_time_to";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Shifts.StrNotes" /></summary>
            public const string StrNotes = "str_notes";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Shifts.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.Shifts.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
