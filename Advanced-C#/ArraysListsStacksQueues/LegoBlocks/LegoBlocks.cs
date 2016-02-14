using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] firsJagged = new int[rows][];
            int[][] secondJagged = new int[rows][];

            ReadJaggedArray(rows, firsJagged);

            ReadJaggedArray(rows, secondJagged);

            for (int i = 0; i < rows; i++)
            {
                Array.Reverse(secondJagged[i]);
            }

            int[][] combined = new int[rows][];

            //Concat two jagdeg arrays
            for (int i = 0; i < rows; i++)
            {
                combined[i] = firsJagged[i].Concat(secondJagged[i]).ToArray();
            }

            bool isMatrix = true;

            //Comparing every row of combined array lenght to the first array lenght
            for (int i = 0; i < rows; i++)
            {
                if (combined[i].Length!=combined[0].Length)
                {
                    isMatrix = false;
                }
            }

            if (isMatrix)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine("[" + string.Join(", ", combined[i]) + "]");
                }
            }
            else
            {
                //for every row get the lenght and then sum all the lenghts and print them
                var combinedLenght = combined.Select(x => x.Length);

                Console.WriteLine("The total number of cells is: {0}",combinedLenght.Sum());
            }
        }

       
        public static void ReadJaggedArray(int rows, int[][] jaggedArray)
        {
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();
            } 
        }
    }
}
