using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethods
{
    class CustomLINQExtensionMethods
    {
        static void Main()
        {

            List<int>numbers=new List<int>(){1,2,3,4,5,6,7,8,9,10};

            var filteredCollection = numbers.WhereNot(x => x % 2 == 0);

            Console.WriteLine(string.Join(",",filteredCollection));

            var students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Sasho", 4),
                new Student("Gosho", 5.2),
                new Student("Misho", 4.9),
                new Student("Penka", 5.99)
            };

            Console.WriteLine(students.Max(s=>s.Grade));
        }
    }
}
