using Shapes.Interfaces;
using System;

namespace Shapes.Classes
{
    class Circle:IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius 
        {
            get { return this.radius; }
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative or zero.");
                }

                this.radius=value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.Pow(this.Radius, 2) * Math.PI;

            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        
    }
}
