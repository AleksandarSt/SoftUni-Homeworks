using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Models
{
    public class Customer : Person, ICustomer
    {
        private decimal totalPurchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal totalPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.TotalPurchaseAmount = totalPurchaseAmount;
        }

        public decimal TotalPurchaseAmount
        {
            get
            {
                return this.totalPurchaseAmount;
            }

            private set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Purchase amount cannot be null.");
                }
                this.totalPurchaseAmount = value;
            }
        }
    }
}
