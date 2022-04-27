using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.DMSysConfig" />
    /// </summary>
    public partial class DMSysConfigMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.DMSysConfig>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.DMSysConfig" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.DMSysConfig> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DM_Sys_Config", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SKey)
                .HasColumnName("sKey")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SValue)
                .HasColumnName("sValue")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.DMSysConfig" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.DMSysConfig" /></summary>
            public const string Name = "DM_Sys_Config";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMSysConfig.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMSysConfig.SKey" /></summary>
            public const string SKey = "sKey";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMSysConfig.SValue" /></summary>
            public const string SValue = "sValue";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMSysConfig.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
