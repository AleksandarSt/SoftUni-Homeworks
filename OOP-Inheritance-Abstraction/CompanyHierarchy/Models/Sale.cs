using CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Models
{
    public class Sale : ISale
    {
        private string productName;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null.");
                }
                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

             set 
            {
                if (value<0)
	            {
		             throw new ArgumentOutOfRangeException("Price cannot be negative.");
	            }
                this.price = value;
            }
        }
    }
}
