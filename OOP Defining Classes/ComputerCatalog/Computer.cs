using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCatalog
{
    class Computer
    {
        private string name;
        private Component graphicCard;
        private Component cpu;
        private Component motherboard;
        private Component ram;
        private Component storage;
        private decimal price;

        #region Properties

        public string Name 
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must not be null or empty");
                }
                this.name = value;
            }
        }

        public decimal Price 
        {
            get { return this.price; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }

                this.price = value; 
            }
        }

        #endregion

        #region Constructors



        #endregion
    }
}
