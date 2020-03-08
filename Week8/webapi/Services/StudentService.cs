using System.Collections.Generic;


public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    public StudentService(IStudentRepository studentRepository) => _studentRepository = studentRepository;

    public List<StudentViewModel> getAllStudents()
    {
        var studentViewModels = new List<StudentViewModel>();
        foreach(var student in _studentRepository.getAllStudents())
        {
            studentViewModels.Add (
                item: new StudentViewModel {
                    StudentId       = student.StudentId,
                    EmailAddress    = student.EmailAddress,
                    Special         = StudentRules.isSpecial(student)
                }
            );
        }            
        return studentViewModels;
    }
}
