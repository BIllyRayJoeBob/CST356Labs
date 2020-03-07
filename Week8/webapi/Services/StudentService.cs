using System.Collections.Generic;

public class StudentService : IStudentService
{
    public List<StudentViewModel> getAllStudents()
    {
        var studentViewModels = new List<StudentViewModel>();
        private readonly IStudentRepository _studentRepository;

        foreach(var student in _studentRepository.getAllStudents())
        {
            studentViewModels.Add(new StudentViewModel {
                StudentId = student.StudentId,
                EmailAddress = student.EmailAddress,
                Special = student.isSpecial()
            });
        }
        
        return studentViewModels;
    }