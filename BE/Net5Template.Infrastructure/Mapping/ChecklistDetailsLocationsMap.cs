using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations" />
    /// </summary>
    public partial class ChecklistDetailsLocationsMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.ChecklistDetailsLocations>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.ChecklistDetailsLocations> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChecklistDetailsLocations", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ChecklistId)
                .HasColumnName("checklist_id")
                .HasColumnType("bigint");

            builder.Property(t => t.ShopId)
                .HasColumnName("shop_id")
                .HasColumnType("int");

            builder.Property(t => t.ScheduleDate)
                .HasColumnName("schedule_date")
                .HasColumnType("bigint");

            builder.Property(t => t.Province)
                .HasColumnName("province")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.District)
                .HasColumnName("district")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Ward)
                .HasColumnName("ward")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Address)
                .HasColumnName("address")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            builder.Property(t => t.CreateDate)
                .HasColumnName("create_date")
                .HasColumnType("bigint");

            builder.Property(t => t.Flag)
                .HasColumnName("flag")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations" /></summary>
            public const string Name = "ChecklistDetailsLocations";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.ChecklistId" /></summary>
            public const string ChecklistId = "checklist_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.ShopId" /></summary>
            public const string ShopId = "shop_id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.ScheduleDate" /></summary>
            public const string ScheduleDate = "schedule_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.Province" /></summary>
            public const string Province = "province";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.District" /></summary>
            public const string District = "district";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.Ward" /></summary>
            public const string Ward = "ward";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.Address" /></summary>
            public const string Address = "address";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.State" /></summary>
            public const string State = "state";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.CreateDate" /></summary>
            public const string CreateDate = "create_date";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.ChecklistDetailsLocations.Flag" /></summary>
            public const string Flag = "flag";
        }
        #endregion
    }
}
