using System.Collections.Generic;
using System.Linq;
using System;

public class StudentRepository : IStudentRepository
{
	public List<Student> getAllStudents()
    {
        try{
            return _dbContext.Student.ToList();
        }
        catch(Exception failure){
            return new List<Student>();
        }
    }
}


/*EOF*/