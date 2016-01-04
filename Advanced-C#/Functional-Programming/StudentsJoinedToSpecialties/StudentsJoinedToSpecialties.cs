using Functional_Programing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsJoinedToSpecialties
{
    class StudentsJoinedToSpecialties
    {
        static void Main()
        {
            var listOfStudents = new List<Student>()
            {
                new Student( "Ivan",    "Ivanov", 19, "165814", "0897698456", "iivanov@yahoo.com", new List<int>{5,   4,  5,  6, }, 1, "Nerds"),
                new Student( "Ivan",    "Angelov", 40, "163215", "0878 79 94 66", "ivan.angelov@gmail.com", new List<int>{2,  2,  4,  4, }, 2, "Cool Guys"),
                new Student( "Petar",   "Georgiev", 29, "125813", "0888 888 621", "p.georgiev@mail.bg", new List<int>{3,  4,  5,  6, }, 1, "Nerds"),
                new Student( "Ivelin",  "Dimitrov", 26, "136814", "0899548123",   "ivelin.dimitrov@gmail.com", new List<int>{5,   5, }, 2, "Cool Guys"),
                new Student( "Sara",    "Velikova", 22, "198612", "+3592 945 14 51",  "sarrrrrra@outlook.com", new List<int>{3,   4,  3,  4, }, 3, "Fitness Maniacs"),
                new Student( "Marieta", "Nikolova", 34, "112313", "0898 320 320", "marietka@abv.bg", new List<int>{2, 2,  2,  3, }, 3, "Fitness Maniacs"),
                new Student( "Marieta", "Kirilova", 24, "184313", "0888000555",   "kirilova@bitex.com", new List<int>{3,  4,  5, }, 2, "Cool Guys"),
                new Student( "Georgi",  "Milanov", 30, "195614", "+359 2 992 11 02",  "gmilanov@yahoo.com", new List<int>{6,  6,  6,  6, }, 1, "Nerds"),
                new Student( "Stamat",  "Penkov", 21, "163112", "0888 11 22 33",  "stamat_penkov@mail.com", new List<int>{2,  4,  5,  4, }, 2, "Cool Guys"),
                new Student( "Ferdinand",   "Katarov", 45, "114812", "0899980182",    "ferdinand2001@abv.bg", new List<int>{3,    5,  5,  3, }, 3, "Fitness Maniacs"),
                new Student( "Elizabeth",   "Grigorova", 28, "141614", "056885521",   "eli_grigorova@gmail.com", new List<int>{5, 6,  5,  4, }, 2, "Cool Guys"),
                new Student( "Yanko",   "Mitov", 20, "154914", "0888 14 78 54",   "yankopolkovnika@abv.bg", new List<int>{2,  3,  3,  5, }, 2, "Cool Guys"),
                new Student( "Antoaneta",   "Parvanova", 37, "171815", "029597431",   "aztrifonova@minedu.government.bg", new List<int>{6, 6, 5,  6, }, 1, "Nerds"),

            };

            //Problem 12.	* Students Joined to Specialties
            //Create a class StudentSpecialty that holds specialty name and faculty number.
            //Create a list of student specialties, where each specialty corresponds to a certain student 
            //(via the faculty number).
            //Print all student names alphabetically along with their faculty number and specialty name. 
            //Use the "join" LINQ operator. Example:

            var listOfSpecialtiesByFacultyNumber = new List<StudentSpecialty>()
            {
                new StudentSpecialty( "Web Developer", "165814"),
                new StudentSpecialty( "Web Developer", "163215"),
                new StudentSpecialty( "PHP Developer", "125813"),
                new StudentSpecialty( "Web Developer", "136814"),
                new StudentSpecialty( "Web Developer", "198612"),
                new StudentSpecialty( "PHP Developer", "112313"),
                new StudentSpecialty( "QA Engineer", "184313"),
                new StudentSpecialty( "Web Developer", "195614"),
                new StudentSpecialty( "QA Engineer", "163112"),
                new StudentSpecialty( "PHP Developer", "114812"),
                new StudentSpecialty( "Web Developer", "141614"),
                new StudentSpecialty( "QA Engineer", "154914"),
                new StudentSpecialty( "PHP Developer", "171815"),
            };

            var joinedToSpecialties =
                from student in listOfStudents
                join specialty in listOfSpecialtiesByFacultyNumber
                    on student.FacultyNumber equals specialty.FacNum
                orderby student.FirstName, student.LastName
                select new
                {
                    Name = student.FirstName + " " + student.LastName,
                    FacNum = specialty.FacNum,
                    Specialty = specialty.SpecialtyName
                };

            Console.WriteLine("Result (Joined Students with Specialties)");
            Console.WriteLine("{0,-20} {1,-15} {2,-15}", "Name", "FacNum", "Specialty");

            foreach (var item in joinedToSpecialties)
            {
                Console.WriteLine("{0,-20} {1,-15} {2,-15}", item.Name, item.FacNum, item.Specialty);
            }
        }
    }
}
