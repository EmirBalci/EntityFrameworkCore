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
    [Migration("20200916064923_OneToOneRelationshipStudent_StudentDetails")]
    partial class OneToOneRelationshipStudent_StudentDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("EntityFrameworkCore.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

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
                            Id = new Guid("5e813969-d695-4fb1-834d-0ebcc67e4472"),
                            Age = 24,
                            IsRegularStudent = false,
                            Name = "Emir Balcı"
                        },
                        new
                        {
                            Id = new Guid("31e89c2d-ba36-461d-8b2e-be12bb9516e9"),
                            Age = 26,
                            IsRegularStudent = false,
                            Name = "Emre Balcı"
                        },
                        new
                        {
                            Id = new Guid("39d22cf1-1dc5-472c-9d6c-8cc9528d913e"),
                            Age = 29,
                            IsRegularStudent = false,
                            Name = "Onur Balcı"
                        },
                        new
                        {
                            Id = new Guid("2041f961-fff8-4412-a80d-66fa152a6492"),
                            Age = 45,
                            IsRegularStudent = false,
                            Name = "Nuran Balcı"
                        });
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.HasOne("EntityFrameworkCore.Entities.Student", "Student")
                        .WithOne("StudentDetails")
                        .HasForeignKey("Entities.StudentDetails", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}