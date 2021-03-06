﻿// <auto-generated />
using System;
using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCore.Api.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200915073754_AdditionalRowInserted")]
    partial class AdditionalRowInserted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkCore.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("AnotherKeyProperty")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsRegularStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("22b0456a-2daa-4635-8aa3-8442e03e4af6"),
                            Age = 24,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "Emir Balcı"
                        },
                        new
                        {
                            Id = new Guid("b0642811-1f03-4154-aacf-185374a194e0"),
                            Age = 26,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "Emre Balcı"
                        },
                        new
                        {
                            Id = new Guid("4c04b1ea-42ee-43af-9507-2f78f2fa8568"),
                            Age = 29,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "Onur Balcı"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
