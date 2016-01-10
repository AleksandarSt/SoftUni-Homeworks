using System;

namespace Methods
{
    class Methods
    {
        static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Every side of the triangle should be positive.");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area =
                Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            return area;
        }

        static string ConvertNumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "Invalid number!";
        }

        static int FindMaximalElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int maximalElement = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maximalElement)
                {
                    maximalElement = elements[i];
                }
            }

            return maximalElement;
        }

        static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }


        static double CalcDistance(
            double firstPointXCoordinate,
            double firstPointYCoordinate,
            double secondPointXCoordinate,
            double secondPointYCoordinate)
        {
            double distance =
                Math.Sqrt((secondPointXCoordinate - firstPointXCoordinate) * (secondPointXCoordinate - firstPointXCoordinate) 
                + (secondPointYCoordinate - firstPointYCoordinate) * (secondPointYCoordinate - firstPointYCoordinate));

            return distance;
        }

        static bool IsVertical(double firstPointXCoordinate, double secondPointXCoordinate)
        {
            var isVertical = (firstPointXCoordinate == secondPointXCoordinate);

            return isVertical;
        }

        private static bool IsHorizontal(double firstPointYCoordinate, double secondPointYCoordinate)
        {
            var isHorizontal = (firstPointYCoordinate == secondPointYCoordinate);

            return isHorizontal;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(ConvertNumberToDigit(5));
            
            Console.WriteLine(FindMaximalElement(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");


            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsHorizontal(-1,2.5));
            Console.WriteLine("Vertical? " + IsVertical(3,3));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
