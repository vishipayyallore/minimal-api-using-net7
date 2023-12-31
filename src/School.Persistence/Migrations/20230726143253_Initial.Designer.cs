﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Persistence;

#nullable disable

namespace School.Persistence.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20230726143253_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("School.Data.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ff0dc0b9-b8dc-4615-b9ec-7ca64183c532"),
                            CourseId = new Guid("bbeea0a9-c9fc-46ae-9f86-0710e76d75d9"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Web API in .NET 7 for Beginners",
                            Duration = 3,
                            ModifiedBy = "Admin",
                            ModifiedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2229), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Web API in .NET 7",
                            PictureUrl = "https://stforeshop.blob.core.windows.net/coursesimages/WebAPIin_NET7.PNG"
                        },
                        new
                        {
                            Id = new Guid("b9389e31-00be-4e7e-869d-cba82845ee30"),
                            CourseId = new Guid("4fb643a0-201a-4a3b-8c04-ed980b749975"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Minimal API in .NET 7 for Beginners",
                            Duration = 3,
                            ModifiedBy = "Admin",
                            ModifiedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Minimal API in .NET 7",
                            PictureUrl = "https://stforeshop.blob.core.windows.net/coursesimages/MinimalAPIin_NET7.PNG"
                        },
                        new
                        {
                            Id = new Guid("bb069472-87e0-4661-a7de-daedd1924d7e"),
                            CourseId = new Guid("7afecaa0-206e-45c7-8681-24d8309952d3"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Blazor WASM in .NET 7 for Beginners",
                            Duration = 5,
                            ModifiedBy = "Admin",
                            ModifiedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2247), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Blazor WASM in .NET 7",
                            PictureUrl = "https://stforeshop.blob.core.windows.net/coursesimages/BlazorWASMin_NET7.PNG"
                        },
                        new
                        {
                            Id = new Guid("84ae2acc-f092-46a7-95a5-2f90a9e5d079"),
                            CourseId = new Guid("c2f50997-de2e-4f2b-9b77-ce4c0fc3a1c4"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "gRPC in .NET 7 for Beginners",
                            Duration = 5,
                            ModifiedBy = "Admin",
                            ModifiedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "gRPC in .NET 7",
                            PictureUrl = "https://stforeshop.blob.core.windows.net/coursesimages/gRPCin_NET7.PNG"
                        },
                        new
                        {
                            Id = new Guid("3f6195e3-1a8e-4308-984b-d6d95ba14d02"),
                            CourseId = new Guid("0fc756c7-84ac-4de1-9807-e9dcafefd1fb"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "App Services in Azure for Beginners",
                            Duration = 9,
                            ModifiedBy = "Admin",
                            ModifiedDate = new DateTimeOffset(new DateTime(2023, 7, 26, 14, 32, 53, 440, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "App Services in Azure",
                            PictureUrl = "https://stforeshop.blob.core.windows.net/coursesimages/AppServicesinAzure.PNG"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
