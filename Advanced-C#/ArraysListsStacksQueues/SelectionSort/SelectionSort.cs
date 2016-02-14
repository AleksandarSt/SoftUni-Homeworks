using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            Console.WriteLine("Enter array elements ...");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int iMin;


            for (int j = 0; j < array.Length; j++)
            {
                /* assume the min is the first element */
                iMin = j;
                /* test against elements after j to find the smallest */
                for (int i = j + 1; i < array.Length; i++)
                {
                    /* if this element is less, then it is the new minimum */
                    if (array[i] < array[iMin])
                    {
                        /* found new minimum; remember its index */
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    swap(j,iMin,array);
                }

            }

            Console.WriteLine(string.Join(" ", array)); 
        }

        private static void swap(int firstIndex, int secondIndex,int[] array)
        {
            int temporary;
            temporary = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temporary;

        }
    }
}
