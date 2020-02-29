using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;



namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController( SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return base.Ok(_dbContext.Student.ToList());
        }

        [HttpGet("student_id")]
        public ActionResult<Student> GetStudent(int studentID)
        {
            var student = _dbContext.Student.SingleOrDefault(p => p.StudentID == studentID);

            if(student != null){
                return student;
            }
            else{
                return NotFound();
            }

        }


    }
}
