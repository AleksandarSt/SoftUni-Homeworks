using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays_Sets_Dictionaries
{
    class FillTheMatrixMain
    {
        static void Main()
        {
            int number;
            bool isInteger;

            do
            {
                Console.WriteLine("Enter integer number N...");
                isInteger = int.TryParse(Console.ReadLine(), out number);

            } while (!isInteger);
            
            //Pattern A
            int[,]matrix=new int[number,number];

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    if (col==0)
                    {
                        matrix[row, col] = row + 1;
                    }
                    else
                    {
                        matrix[row, col] = matrix[row, col - 1] + number; 
                    }
                    
                }
            }

            PrintSquareMatrix(matrix);
            Console.WriteLine();

            //Pattern B
            int currentNumber = 1;
            for (int col = 0; col < number; col++)
            {
                for (int row = 0, reversedRow = number - 1; row < number; row++, reversedRow--)
                {
                    if (col % 2 == 0)
                    {
                        matrix[row, col] = currentNumber;
                    }
                    else
                    {
                        matrix[reversedRow, col] = currentNumber;
                    }
                    currentNumber++;
                }
            }

            PrintSquareMatrix(matrix);
        }

        public static void PrintSquareMatrix(int[,] matrix)
        {
            int number = (int)Math.Sqrt(matrix.Length);

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    Console.Write("{0} ",matrix[row,col]);

                }
                Console.WriteLine();
            }
        }
    }
}
