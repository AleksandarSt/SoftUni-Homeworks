using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{

    public delegate decimal CalculateInterest(decimal sum, decimal interest, decimal years);

    public class InterestCalculator
    {
        public InterestCalculator(decimal money, decimal interest, decimal years, CalculateInterest interestMethod)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.InterestMethod = interestMethod;
        }

        public decimal Money { get; set; }

        public decimal Interest { get; set; }

        public decimal Years { get; set; }

        public CalculateInterest InterestMethod { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Money = {0}\nInterest = {1}\nYears = {2}\nTotalSum = {3:F4}\n",
                this.Money,
                this.Interest,
                this.Years,
                this.InterestMethod(Money,Interest,Years));
        }
    }
}
