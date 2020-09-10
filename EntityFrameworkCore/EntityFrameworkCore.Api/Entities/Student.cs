using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Api.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Column("StudentId")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage = "50 Karakterden az olmalı...")]
        public string Name { get; set; }
        public int? Age { get; set; }
        [NotMapped]
        public int LocalCalculation { get; set; }
        public Guid AnotherKeyProperty { get; set; }
        public bool IsRegularStudent { get; set; }
    }
}
