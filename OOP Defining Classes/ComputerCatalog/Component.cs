using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        #region Properties

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Component Name must not be null or empty");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Component Details must not be null or empty");
                }
                this.details = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }

                this.price = value;
            }
        }

        #endregion

        #region Constructors

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price)
            :this(name,null,0)
        {
 
        }

        #endregion

        #region Methods



        #endregion
    }
}
