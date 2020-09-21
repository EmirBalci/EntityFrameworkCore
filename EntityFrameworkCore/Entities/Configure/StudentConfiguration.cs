using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configure
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.Property(s => s.Age)
                .IsRequired(false);
            builder.Property(s => s.IsRegularStudent)
                .HasDefaultValue(true);
            builder.HasMany(e => e.Evaluations)
                .WithOne(s => s.Student)
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData
            (
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Emir Balcı",
                    Age = 24
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Emre Balcı",
                    Age = 26
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Onur Balcı",
                    Age = 29
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Nuran Balcı",
                    Age = 45
                }
            );
        }
    }
}
