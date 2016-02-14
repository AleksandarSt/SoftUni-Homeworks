using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            do
            {
                Console.WriteLine("Enter array elements ...");
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Array.Sort(array);

                Console.WriteLine(string.Join(" ", array)); 


            } while (true);
        }
    }
}
