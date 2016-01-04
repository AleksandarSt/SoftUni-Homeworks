using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OfficeStuff
{
    class OfficeStuff
    {
        static void Main()
        {

            int numberOfCompanies = int.Parse(Console.ReadLine());

            List<Company> companies = new List<Company>();

            char[] separator = {'-', '|', ' '};

            for (int i = 0; i < numberOfCompanies; i++)
            {
                string[] tokens=Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);

                string companyName = tokens[0];
                int amount = int.Parse(tokens[1]);
                string product = tokens[2];

                companies.Add
                    (
                    new Company(companyName,amount,product)
                    );
            }

            Console.WriteLine();

            for (int i = 0; i < numberOfCompanies; i++)
            {
                Console.WriteLine(companies[i]);
            }
        }
    }
}
