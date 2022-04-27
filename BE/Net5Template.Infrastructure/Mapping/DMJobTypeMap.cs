using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Net5Template.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Net5Template.Data.Entities.DMJobType" />
    /// </summary>
    public partial class DMJobTypeMap
        : IEntityTypeConfiguration<Net5Template.Data.Entities.DMJobType>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Net5Template.Data.Entities.DMJobType" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Net5Template.Data.Entities.DMJobType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DM_JobType", "mobile");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.JobType)
                .HasColumnName("job_type")
                .HasColumnType("int");

            builder.Property(t => t.JobName)
                .HasColumnName("job_name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IntCategoryTask)
                .HasColumnName("int_category_task")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Delimiter)
                .HasColumnName("delimiter")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.SFilter)
                .HasColumnName("sFilter")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Net5Template.Data.Entities.DMJobType" /></summary>
            public const string Schema = "mobile";
            /// <summary>Table Name constant for entity <see cref="Net5Template.Data.Entities.DMJobType" /></summary>
            public const string Name = "DM_JobType";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMJobType.Id" /></summary>
            public const string Id = "id";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMJobType.JobType" /></summary>
            public const string JobType = "job_type";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMJobType.JobName" /></summary>
            public const string JobName = "job_name";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMJobType.IntCategoryTask" /></summary>
            public const string IntCategoryTask = "int_category_task";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMJobType.Delimiter" /></summary>
            public const string Delimiter = "delimiter";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMJobType.SFilter" /></summary>
            public const string SFilter = "sFilter";
            /// <summary>Column Name constant for property <see cref="Net5Template.Data.Entities.DMJobType.State" /></summary>
            public const string State = "state";
        }
        #endregion
    }
}
