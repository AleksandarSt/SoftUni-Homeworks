using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            //var result = companies
            //    .GroupBy(company => new { company.CompanyName })
            //    .Select
            //    (
            //        group =>
            //            new
            //            {
            //                Name = group.Key.CompanyName,
            //                Products = group.ToList()
            //            }
            //    )
            //    .OrderBy(group => group.Name);


            var result =
                (from company in companies
                 group company by new { company.CompanyName, company.Product }
                     into grp
                     select new
                     {
                         Name = grp.Key.CompanyName,
                         Product = grp.Key.Product,
                         Amount = grp.Sum(x => x.Amount)
                     })
                    .OrderBy(x => x.Name)
                    .ToList();


           

            string currentCompany = result[0].Name;
            Console.Write("{0}:", currentCompany);

            for (int i = 0; i < result.Count(); i++)
            {

                if (currentCompany != result[i].Name)
                {
                    currentCompany = result[i].Name;
                    Console.Write("{0}:", currentCompany);
                }

                StringBuilder output = new StringBuilder();
                //foreach (var product in grp.Product)
                //{

                output.Append(" ");
                output.Append(result[i].Product);
                output.Append("-");
                output.Append(result[i].Amount);
                output.Append(",");
                //Console.Write(" {0}-{1},", company.Product, company.Amount);
                //}
                //output.Remove(output.Length - 1, 1);

                if ((i > 0 && i < result.Count() - 1 && currentCompany != result[i + 1].Name)||i==result.Count()-1)
                {
                    output.Remove(output.Length - 1, 1);

                    Console.WriteLine(output);
                }
                else
                {
                    Console.Write(output);
                }
                
                output.Clear();
            }

            //foreach (var grp in result)
            //{
                
            //    Console.Write("{0}:", grp.Name);
            //    StringBuilder output = new StringBuilder();
            //    //foreach (var product in grp.Product)
            //    //{

            //        output.Append(" ");
            //        output.Append(grp.Product);
            //        output.Append("-");
            //        output.Append(grp.Amount);
            //        output.Append(",");
            //        //Console.Write(" {0}-{1},", company.Product, company.Amount);
            //    //}
            //    //output.Remove(output.Length - 1, 1);
            //    Console.Write(output);
            //    output.Clear();
            //}
        }
    }
}
