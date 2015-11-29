using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_Worker
{
    class Main_Program
    {

        static void Main()
        {
            List<Student> Students = new List<Student>()
            {
                new Student("Ivan","Ivanov","367747"),
                new Student("Gosho","Malkiq","abcdert"),
                new Student("Petko","Tupalov","4646111"),
                new Student("Dobrin","Makarov","7879111"),
                new Student("Marin","Genhev","1dfgdfg11"),
                new Student("Stamat","Jivkov","111fhfh11"),
                new Student("Peshi","Aleksiev","11hssf1"),
                new Student("Andrei","Stoyanov","dsdfs111"),
                new Student("Rumen","Buhalov","555677688"),
                new Student("Zarko","Todorov","2344551"),
            };

            Students
                .OrderByDescending(x => x.FacultyNumber);

            foreach (var item in Students)
            {
                Console.WriteLine(item.FacultyNumber.ToString());
            }
        }
    }
}
