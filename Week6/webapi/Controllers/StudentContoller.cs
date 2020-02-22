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
    [Route("[controller]")]
    
    public class StudentController : ControllerBase
    {

        [HttpGet]
          public ActionResult<List<Student>> Get()
        {
            return Ok(getStudents());
        }

        private List<Student> getStudents()
        {
            return InMemory.Students;
        }      

    }
}
