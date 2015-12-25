using System;
using Point3D;

namespace Point3D
{
    class MainProgram
    {
        public static void Main()
        {
            Point somePoint = new Point(3, 4, 5);

            Console.WriteLine(somePoint);

            Console.WriteLine(Point.StartingCoord);
        }
    }
}
