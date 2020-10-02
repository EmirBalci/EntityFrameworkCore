using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using EntityFrameworkCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public WeatherForecastController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _context.Students
                   .AsNoTracking()
                   .Include(e => e.Evaluations)
                   .Include(ss => ss.StudentSubjects)
                   .ThenInclude(s => s.Subject)
                   .Where(s => s.Age > 25)
                   .ToList();

            return Ok(students);
        }

        [HttpPost]
        [Route("/api/student")]
        public IActionResult Post([FromBody] Student student)
        {
            if (student == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();
            _context.Add(student);
            _context.SaveChanges();
            return Created("URI of the created entity", student);
        }

        [HttpPost("postrange")]
        public IActionResult PostRange([FromBody] IEnumerable<Student> students)
        {
            //additional checks
            _context.AddRange(students);
            _context.SaveChanges();
            return Created("URI is going here", students);
        }

        [HttpPost]
        public IActionResult Post2([FromBody] Student student)
        {
            //validation code goes here
            student.StudentDetails = new StudentDetails
            {
                Address = "Added Address",
                AdditionalInformation = "Additional information added"
            };
            _context.Add(student);
            _context.SaveChanges();
            return Created("URI of the created entity", student);
        }

        [HttpPut("{id}")]
        public IActionResult PUT(Guid id, [FromBody] Student student)
        {
            var dbStudent = _context.Students
                .FirstOrDefault(s => s.Id.Equals(id));
            dbStudent.Age = student.Age;
            dbStudent.Name = student.Name;
            dbStudent.IsRegularStudent = student.IsRegularStudent;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}/relationship")]
        public IActionResult UpdateRelationhip(Guid id, [FromBody] Student student)
        {
            var dbStudent = _context.Students
                .FirstOrDefault(s => s.Id.Equals(id));
            dbStudent.StudentDetails = new StudentDetails
            {
                Id = new Guid("e2a3c45d-d19a-4603-b983-7f63e2b86f14"),
                Address = "added address",
                AdditionalInformation = "Additional information for student 2"
            };
            _context.SaveChanges();
            return NoContent();
        }
    }
}
