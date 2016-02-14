using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array elements ...");
            float[] array = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();

            List<int> integers = new List<int>();
            List<float> floats=new List<float>();

            

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == Math.Floor(array[i]))
                {
                    integers.Add((int)array[i]);
                }
                else
                {
                    floats.Add(array[i]);
                }
            }
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}", string.Join(" ", floats),
                floats.Min(), floats.Max(), floats.Sum(), floats.Average());
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}", string.Join(" ", integers),
                integers.Min(), integers.Max(), integers.Sum(), integers.Average());
            
        }
    }
}
