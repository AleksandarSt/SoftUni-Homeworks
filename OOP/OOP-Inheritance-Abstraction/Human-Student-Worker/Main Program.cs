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
            List<Student> students = new List<Student>()
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

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Petar","Ivanov",220,8),
                new Worker("Martin","Petrov",320,10),
                new Worker("John","Doe",400,12),
                new Worker("Duncan","McLeod",2200,6),
                new Worker("Asparuh","Todorov",120,8),
                new Worker("Pesho","Georgiev",340,8),
                new Worker("Martin","Ivanov",220,8),
                new Worker("Lubo","Ganev",620,6),
                new Worker("Cvetan","Cvetanov",520,8),
                new Worker("Oleg","Borisov",290,8),
            };

            var sortedStudents = students.OrderByDescending(x => x.FacultyNumber);
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());

            var mergedList = new List<Human>().Concat(sortedStudents).Concat(sortedWorkers);

            var mergedListSorted = mergedList.OrderBy(n => n.FirstName).ThenBy(l => l.LastName);

            foreach (var item in mergedListSorted)
            {
                Console.WriteLine("First Name: {0}\nLast Name: {1}\n{2}",item.FirstName,item.LastName,new string('-',25));
            }

            //foreach (var item in sortedStudents)
            //{
            //    Console.WriteLine(item.FacultyNumber.ToString());
            //}

            //foreach (var item in sortedWorkers)
            //{
            //    Console.WriteLine("{0}-->{1}",item.FirstName,item.MoneyPerHour());
            //}
        }
    }
}
