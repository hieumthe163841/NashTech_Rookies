using Assignment3_Asp.Net_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Net;

namespace Assignment3_Asp.Net_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {

        private static List<Students> _students = new List<Students>()
        {
            new Students(){Id=1, Name="John", Age=20},
            new Students(){Id=2, Name="Jane", Age=21}
        };
        [HttpGet]
     
        public IActionResult CreateStudent(Students student)
        {
            _students.Add(student);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _students.Find(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }
    }
}
