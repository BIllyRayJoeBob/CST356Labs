using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {         
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