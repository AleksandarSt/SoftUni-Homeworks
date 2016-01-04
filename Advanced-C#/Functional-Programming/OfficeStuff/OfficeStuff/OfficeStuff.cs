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

            var result = companies
                .GroupBy(company => new { company.CompanyName, company.Product })
                .Select
                (
                    group =>
                        new
                        {
                            Name = group.Key.CompanyName,
                            Product=group.Key.Product,
                            Products = group.OrderByDescending(x => x.Amount).ToList()
                        }
                )
                .OrderBy(group => group.Name);

            //var result=
            //    from company in companies
            //    group company by company.CompanyName into g
            //    group g by company.

            foreach (var group in result)
            {
                Console.Write("{0}:",group.Name);
                StringBuilder output = new StringBuilder();
                foreach (var company in group.Products)
                {

                    output.Append(" ");
                    output.Append(company.Product);
                    output.Append("-");
                    output.Append(company.Amount);
                    output.Append(",");
                    //Console.Write(" {0}-{1},",company.Product,company.Amount);
                }
                output.Remove(output.Length - 1, 1);
                Console.WriteLine(output);
                output.Clear();
            }
        }
    }
}
