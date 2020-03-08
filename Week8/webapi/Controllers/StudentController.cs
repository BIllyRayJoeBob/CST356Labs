using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class StudentController : ControllerBase
    {
        /* StudentService-based constructor */
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService) => _studentService = studentService;

        // /* cbContext-based constructor */
        // private readonly SchoolContext _dbContext;
        // public StudentController(SchoolContext dbContext){
        //     _dbContext = dbContext;
        // }

        [HttpGet]
        public ActionResult<List<Student>> getAllStudents() {
            return Ok(_studentService.getAllStudents());
        }
    }
}
