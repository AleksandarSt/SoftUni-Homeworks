using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Classes
{
    public abstract class Customer
    {
        private string name;

        public Customer(string name) 
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Customer name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }
        }
    }
}
