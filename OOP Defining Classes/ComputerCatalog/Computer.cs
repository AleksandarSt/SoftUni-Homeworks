using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComputerCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;
        private decimal price;

        #region Properties

        public string Name 
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Compuer Name must not be null or empty");
                }
                this.name = value;
            }
        }

        public List<Component> Components
        {
            get
            {
                return this.components;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("Computer can not be without  components!");
                }
                this.components = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.components.Sum(component => component.Price);
            }
        }

        #endregion

        #region Constructors

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Computer name: {0}", this.Name));
            foreach (var component in this.Components)
            {
                result.AppendLine(string.Format("{0}{2} {1:c2}", component.Name, component.Price,
                    string.IsNullOrWhiteSpace(component.Details) ? ":" : ":" + " " + component.Details+" >>>"));
            }
            result.AppendLine(string.Format("Total price: {0:c2}", this.Price));
            return result.ToString();
        }
        #endregion
    }
}
