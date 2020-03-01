using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Database;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;
        
        public StudentController(SchoolContext dbContext){
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> getAllStudents() {
            return Ok(_dbContext.Student.ToList());
            }
    }
}
