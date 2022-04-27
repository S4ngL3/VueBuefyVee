using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.PgdWorkCalendar" />
    /// </summary>
    public partial class PgdWorkCalendarMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.PgdWorkCalendar>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.PgdWorkCalendar" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.PgdWorkCalendar> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PgdWorkCalendar", "mobile");

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

            builder.Property(t => t.StrUserName)
                .HasColumnName("str_user_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.UserFullName)
                .HasColumnName("user_full_name")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.IntSchedulesDate)
                .HasColumnName("int_schedules_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntShiftsId)
                .HasColumnName("int_shifts_id")
                .HasColumnType("int");

            builder.Property(t => t.IntCreateBy)
                .HasColumnName("int_create_by")
                .HasColumnType("int");

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntModifyBy)
                .HasColumnName("int_modify_by")
                .HasColumnType("int");

            builder.Property(t => t.IntModifyDate)
                .HasColumnName("int_modify_date")
                .HasColumnType("bigint");

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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.PgdWorkCalendar" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.PgdWorkCalendar" /></summary>
            public const string Name = "PgdWorkCalendar";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntShopId" /></summary>
            public const string IntShopId = "int_shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntUserId" /></summary>
            public const string IntUserId = "int_user_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.StrUserName" /></summary>
            public const string StrUserName = "str_user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.UserFullName" /></summary>
            public const string UserFullName = "user_full_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntSchedulesDate" /></summary>
            public const string IntSchedulesDate = "int_schedules_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntShiftsId" /></summary>
            public const string IntShiftsId = "int_shifts_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntCreateBy" /></summary>
            public const string IntCreateBy = "int_create_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntModifyBy" /></summary>
            public const string IntModifyBy = "int_modify_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.StrNotes" /></summary>
            public const string StrNotes = "str_notes";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.PgdWorkCalendar.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
