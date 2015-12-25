using Point3D;
using System;

namespace DistanceCalculator
{
    static class DistanceCalculator
    {
        public static double  CalculateDistance(Point a, Point b)
        {
            return Math.Sqrt(
                (a.XCord - b.XCord) * (a.XCord - b.XCord) +
                (a.YCord - b.YCord) * (a.YCord - b.YCord) +
                (a.ZCord - b.ZCord) * (a.ZCord - b.ZCord)
                );
        }
    }
}
