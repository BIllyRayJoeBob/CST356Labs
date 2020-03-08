using System.Collections.Generic;
using System.Linq;
using System;
using Database;

public class StudentRepository : IStudentRepository
{
    private readonly SchoolContext _dbContext;

    //CONSTRUCTOR
    public StudentRepository (SchoolContext dbContext)
    {
        _dbContext = dbContext;
    }

	public List<Student> getAllStudents()
    {
        try{
            return _dbContext.Student.ToList();
        }
        catch(Exception ex){
            return new List<Student>();
        }
    }
}

/*EOF*/