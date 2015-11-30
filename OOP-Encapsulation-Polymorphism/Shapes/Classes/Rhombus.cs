using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Classes
{
    class Rhombus:BasicShape
    {
        public Rhombus(double width, double height)
            :base(width,height)
        {
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 4 * this.Width;

            return perimeter;
        }

        public override double CalculateArea()
        {
            double area = this.Width * this.Height;

            return area;
        }
    }
}
