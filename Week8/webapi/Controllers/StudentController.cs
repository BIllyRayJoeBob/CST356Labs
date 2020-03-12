using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService){
            _studentService = studentService;
        }
        [HttpGet]
        public ActionResult<List<Student>> getAllStudents(){
            return Ok(_studentService.getAllStudents());
        }
    }
}