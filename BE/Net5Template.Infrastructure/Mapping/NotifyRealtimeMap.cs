using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.NotifyRealtime" />
    /// </summary>
    public partial class NotifyRealtimeMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.NotifyRealtime>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.NotifyRealtime" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.NotifyRealtime> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("NotifyRealtime", "mobile");

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

            builder.Property(t => t.StrCode)
                .HasColumnName("str_code")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StrTitle)
                .HasColumnName("str_title")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.StrContent)
                .HasColumnName("str_content")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.StrContentOld)
                .HasColumnName("str_content_old")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.StrContentNew)
                .HasColumnName("str_content_new")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IntStatus)
                .HasColumnName("int_status")
                .HasColumnType("int");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntUserIdUpdateWc)
                .HasColumnName("int_user_id_update_wc")
                .HasColumnType("int");

            builder.Property(t => t.StrUserNameUpdateWc)
                .HasColumnName("str_user_name_update_wc")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SessionKey)
                .HasColumnName("session_key")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.NotifyRealtime" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.NotifyRealtime" /></summary>
            public const string Name = "NotifyRealtime";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.IntUserId" /></summary>
            public const string IntUserId = "int_user_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.StrUserName" /></summary>
            public const string StrUserName = "str_user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.StrCode" /></summary>
            public const string StrCode = "str_code";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.StrTitle" /></summary>
            public const string StrTitle = "str_title";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.StrContent" /></summary>
            public const string StrContent = "str_content";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.StrContentOld" /></summary>
            public const string StrContentOld = "str_content_old";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.StrContentNew" /></summary>
            public const string StrContentNew = "str_content_new";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.IntUserIdUpdateWc" /></summary>
            public const string IntUserIdUpdateWc = "int_user_id_update_wc";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.StrUserNameUpdateWc" /></summary>
            public const string StrUserNameUpdateWc = "str_user_name_update_wc";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.NotifyRealtime.SessionKey" /></summary>
            public const string SessionKey = "session_key";
        }
        #endregion
    }
}
