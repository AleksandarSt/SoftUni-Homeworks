using Shapes.Classes;
using Shapes.Interfaces;
using System;

namespace Shapes
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[6]
            {
                new Rectangle(6,10),
                new Rectangle(8,5),
                new Rhombus(12,7.4),
                new Rhombus(9,9),
                new Circle(22),
                new Circle(123.123)
            };

            foreach (var item in shapes)
            {
                Console.WriteLine("Perimeter of {0} is {1:F2}",item.GetType().Name,item.CalculatePerimeter());
                Console.WriteLine("Area of {0} is {1:F2}",item.GetType().Name, item.CalculateArea());
            }


        }
    }
}
