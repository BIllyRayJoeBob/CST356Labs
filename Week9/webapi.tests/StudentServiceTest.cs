using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        _studentRepository  = A.Fake<IStudentRepository>();
        _studentService     = new StudentService(_studentRepository);
    }

    private readonly List<Student> AllTestStudents = 
    new List<Student>{
        new Student {
            StudentId       = 918000001,
            EmailAddress    = "billyray.bob@school.edu"
        },
        new Student {
            StudentId       = 918000002,
            EmailAddress    = "phong.nguyen@school.edu"
        },
        new Student {
            StudentId       = 918000003,
            EmailAddress    = "lucas.cordova@school.edu"
        },
        new Student {
            StudentId       = 918000004,
            EmailAddress    = "gerald.aden@school.edu"
        },
        new Student {
            StudentId       = 918000005,
            EmailAddress    = "pramod.govindan@school.edu"
        }
    };

    private readonly List<Student> NormalTestStudents = 
    new List<Student>{  
        new Student {
            StudentId       = 918000004,
            EmailAddress    = "gerald.aden@school.edu"
        },
        new Student {
            StudentId       = 918000005,
            EmailAddress    = "pramod.govindan@school.edu"
        }
    };

    private readonly List<Student> SpecialTestStudents = 
    new List<Student>{        
        new Student {
            StudentId       = 918000001,
            EmailAddress    = "billyray.bob@school.edu"
        },
        new Student {
            StudentId       = 918000002,
            EmailAddress    = "phong.nguyen@school.edu"
        },
        new Student {
            StudentId       = 918000003,
            EmailAddress    = "lucas.cordova@school.edu"
        }
    };

    [Test]
    public void ShouldReturnNormalStudents()
    {
        // Arrange (Given)?
        A.CallTo(() => _studentRepository.getAllStudents()).Returns(NormalTestStudents);
        // Act (when)?
        var studentViewModels = _studentService.getAllStudents();
        // Assert (NUnit Assertions)(Then)?
        Assert.That(studentViewModels.Any(student => student.Special), Is.EqualTo(false));
        // Assert (FluentAssertions)(Then)?
        studentViewModels.Any(student => student.Special).Should().BeFalse();
    }

    [Test]
    public void ShouldReturnSpecialStudents()
    {
        // Arrange (Given)?
        A.CallTo(() => _studentRepository.getAllStudents()).Returns(SpecialTestStudents);
        // Act (when)?
        var studentViewModels = _studentService.getAllStudents();
        // Assert (FluentAssertions)(Then)?
        studentViewModels.Count(student => student.Special).Should().Be(3);
    }

    [Test]
    public void ShouldReturnAllStudents()
    {
        // Arrange (Given)?
        A.CallTo(() => _studentRepository.getAllStudents()).Returns(AllTestStudents);
        // Act (when)?
        var studentViewModels = _studentService.getAllStudents();
        // Assert (FluentAssertions)(Then)?
        studentViewModels.Count(student => student.Special).Should().Be(3);        
        studentViewModels.Count(student => !student.Special).Should().Be(2);
    }
}