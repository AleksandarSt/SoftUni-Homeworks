using System;
using Point3D;
using DistanceCalculator;

namespace DistanceCalculator
{
    class MainProgram
    {
        static void Main()
        {
            Point somePoint = new Point(3, 4, 5);
            Point secondPoint = new Point(1, 2, 3);

           double result= DistanceCalculator.CalculateDistance(somePoint, secondPoint);

           Console.WriteLine("{0:0.000}",result);
        }
    }
}
