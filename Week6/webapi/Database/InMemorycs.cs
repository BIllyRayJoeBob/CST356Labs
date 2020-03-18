using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student>(){
            new Student{
                Id = 1,
                StudentId = "918000001",
                EmailAddress = "billyray.bob@school.edu"
            },
            new Student{
                Id = 2,
                StudentId = "918000002",
                EmailAddress = "phong.nguyen@school.com"
            },
            new Student{
                Id = 3,
                StudentId = "918000003",
                EmailAddress = "lucas.cordova@school.edu"
            },
            new Student{
                Id = 4,
                StudentId = "918000004",
                EmailAddress = "gerald.aden@school.edu"
            },
            new Student{
                Id = 5,
                StudentId = "918000005",
                EmailAddress = "pramod.govindan@school.edu"
            }
        };


        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                Id = 1,
                FirstName = "Billy Ray",
                MiddleName = "Joe",
                LastName = "Bob"
            },
            new Instructor {
                Id = 2,
                FirstName = "Phong",
                MiddleName = "",
                LastName = "Nguyen"
            },
            new Instructor {
                Id = 3,
                FirstName = "Lucas",
                MiddleName = "",
                LastName = "Cordova"
            },
            new Instructor {
                Id = 4,
                FirstName = "Gerald",
                MiddleName = "",
                LastName = "Aden"
            },
            new Instructor {
                Id = 5,
                FirstName = "Pramod",
                MiddleName = "",
                LastName = "Govindan"
            }
        };
    }
}