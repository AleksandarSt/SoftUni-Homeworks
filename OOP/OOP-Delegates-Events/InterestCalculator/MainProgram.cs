using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class MainProgram
    {
        private const int periods=12;

        static void Main()
        {
            var compound = new InterestCalculator(500, 5.6m, 10, GetCompoundInterest);
            Console.WriteLine(compound);

            var simple = new InterestCalculator(2500, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine(simple);
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, decimal years)
        {
            decimal result = sum * (1 + ((interest / 100) * years));
            return result;
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, decimal years)
        {
            decimal result = sum * (decimal)Math.Pow((double)(1 + ((interest/100) / periods)), (double)years * periods);
            return result;
        }
    }
}
