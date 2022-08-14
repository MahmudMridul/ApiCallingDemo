using ApiCallingDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCallingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static IList<Student> students = new[]
        {
            new Student { Id = 1, Name = "A" },
            new Student { Id = 2, Name = "B" },
            new Student { Id = 3, Name = "C" },
            new Student { Id = 4, Name = "D" },
            new Student { Id = 5, Name = "E" }

        };


        // GET: api/<ContactController>
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return Ok(students);
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            Student student = students.SingleOrDefault(student => student.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }
    }
}
