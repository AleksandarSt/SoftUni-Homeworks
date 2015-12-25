using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplicator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMatrix = new double[,]
            {
                { 1, 3 }, 
                { 5, 7 } 
            };

            var secondMatrix = new double[,]
            { 
                { 4, 2 }, 
                { 1, 5 } 
            };

            var resultMatrix = MultiplyTwoMatrices(firstMatrix, secondMatrix);

            for (int row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    Console.Write(resultMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Calculate product of two matriecies
        /// </summary>
        /// <param name="firstMatrix"></param>
        /// <param name="secondMatrix"></param>
        /// <returns></returns>
        static double[,] MultiplyTwoMatrices(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new Exception("Error!");
            }

            //var firstResult = firstMatrix.GetLength(1);

            var resultMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < firstMatrix.GetLength(1); k++)
                    {
                        resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }
            return resultMatrix;
        }
    }
}