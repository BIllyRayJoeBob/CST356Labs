using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService){
            _studentService = studentService;
        }
        
        public StudentController(SchoolContext dbContext){
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> getAllStudents() {
            return Ok(_studentService.getAllStudents());
            }
    }
}
