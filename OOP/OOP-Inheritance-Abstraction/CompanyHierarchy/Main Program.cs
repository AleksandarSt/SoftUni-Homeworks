using CompanyHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class MainProgram
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Developer(131, "Michael", "Howell", 958.88m, Department.Production),
                new SalesEmployee(159, "Barry", "Hart", 1298.88m, Department.Sales),
                new SalesEmployee(85, "Alice", "McBeal", 798.88m, Department.Sales),
                new Manager(13, "John", "Jenkins", 698.88m, Department.Accounting),
                new Manager(3393, "Steven", "Rosey", 1998.88m, Department.Marketing),
                new Developer(568, "Norma", "Gerrard", 2098.88m, Department.Production),
                new SalesEmployee(157, "Heather", "Simpson", 80.88m, Department.Sales),
                new SalesEmployee(279, "Samuel", "Jackson", 80.88m, Department.Sales),
                new Manager(16, "Kathy", "Lawson", 9908.88m, Department.Marketing),
                new Developer(39, "Janet", "Willis", 198.88m, Department.Production),
                new Manager(823, "Kelly", "Gutierrez", 398.88m, Department.Accounting),
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
