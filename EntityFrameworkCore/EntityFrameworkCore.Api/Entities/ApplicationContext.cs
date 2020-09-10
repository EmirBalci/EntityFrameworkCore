using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Api.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Student>().Property(s => s.Id).HasColumnName("StudentId");
            modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(s => s.Age).IsRequired(false);
            modelBuilder.Entity<Student>().Ignore(s => s.LocalCalculation);
            modelBuilder.Entity<Student>().Property(s => s.IsRegularStudent).HasDefaultValue(false);
            modelBuilder.Entity<Student>().HasKey(s => new { s.Id, s.AnotherKeyProperty });
        }
    }
}
