using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.WorkCalendar" />
    /// </summary>
    public partial class WorkCalendarMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.WorkCalendar>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.WorkCalendar" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.WorkCalendar> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("WorkCalendar", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntUserId)
                .HasColumnName("int_user_id")
                .HasColumnType("int");

            builder.Property(t => t.StrUserName)
                .HasColumnName("str_user_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IntSchedulesDate)
                .HasColumnName("int_schedules_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntSchedulesTime)
                .HasColumnName("int_schedules_time")
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

            builder.Property(t => t.IntSessionTime)
                .HasColumnName("int_session_time")
                .HasColumnType("int");

            builder.Property(t => t.IntWorkplace)
                .HasColumnName("int_workplace")
                .HasColumnType("int");

            builder.Property(t => t.IntColor)
                .HasColumnName("int_color")
                .HasColumnType("int");

            builder.Property(t => t.StrWorkName)
                .HasColumnName("str_work_name")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.WorkCalendar" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.WorkCalendar" /></summary>
            public const string Name = "WorkCalendar";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntUserId" /></summary>
            public const string IntUserId = "int_user_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.StrUserName" /></summary>
            public const string StrUserName = "str_user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntSchedulesDate" /></summary>
            public const string IntSchedulesDate = "int_schedules_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntSchedulesTime" /></summary>
            public const string IntSchedulesTime = "int_schedules_time";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntModifyBy" /></summary>
            public const string IntModifyBy = "int_modify_by";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntSessionTime" /></summary>
            public const string IntSessionTime = "int_session_time";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntWorkplace" /></summary>
            public const string IntWorkplace = "int_workplace";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntColor" /></summary>
            public const string IntColor = "int_color";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.StrWorkName" /></summary>
            public const string StrWorkName = "str_work_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.WorkCalendar.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
