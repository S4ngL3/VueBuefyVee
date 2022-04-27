using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.UserIds" />
    /// </summary>
    public partial class UserIdsMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.UserIds>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.UserIds" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.UserIds> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserIds", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.StrUserName)
                .HasColumnName("str_user_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StrDeviceId)
                .HasColumnName("str_device_id")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.StrFcmId)
                .HasColumnName("str_fcm_id")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IntCreateDate)
                .HasColumnName("int_create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntModifyDate)
                .HasColumnName("int_modify_date")
                .HasColumnType("bigint");

            builder.Property(t => t.IntStatus)
                .HasColumnName("int_status")
                .HasColumnType("int");

            builder.Property(t => t.IntType)
                .HasColumnName("int_type")
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
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.UserIds" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.UserIds" /></summary>
            public const string Name = "UserIds";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.StrUserName" /></summary>
            public const string StrUserName = "str_user_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.StrDeviceId" /></summary>
            public const string StrDeviceId = "str_device_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.StrFcmId" /></summary>
            public const string StrFcmId = "str_fcm_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.IntCreateDate" /></summary>
            public const string IntCreateDate = "int_create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.IntModifyDate" /></summary>
            public const string IntModifyDate = "int_modify_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.IntStatus" /></summary>
            public const string IntStatus = "int_status";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.IntType" /></summary>
            public const string IntType = "int_type";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.UserIds.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
