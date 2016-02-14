using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            const int subMatrixSize = 3;

            char[] separator = new[] {',', ' '};
            string[] rowsAndCols = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);

            int[,] matrix=new int[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col]=int.Parse(line[col]);
                }
            }

            int bestSum=int.MinValue;
            int currentSum = 0;
            int[,] currentSubMatrix = new int[subMatrixSize, subMatrixSize];
            int[,] bestSubMatrix = new int[subMatrixSize, subMatrixSize];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + subMatrixSize - 1 < rows && col + subMatrixSize - 1 < cols)
                    {
                        currentSubMatrix=GenerateCurrentSubMatrix(subMatrixSize, matrix, row, col);

                        currentSum = CalculateSquareMatrixSum(currentSubMatrix);

                        if (currentSum > bestSum)
                        {
                            bestSum = currentSum;

                            bestSubMatrix = currentSubMatrix;
                        }

                    }
                }
            }

            Console.WriteLine("Sum = {0}",bestSum);

            PrintSquareMatrix(bestSubMatrix);
        }

        public static void PrintSquareMatrix(int[,] matrix)
        {
            int number = (int)Math.Sqrt(matrix.Length);

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);

                }
                Console.WriteLine();
            }
        }

        public static int[,] GenerateCurrentSubMatrix(int subMatrixSize, int[,] matrix, int row, int col)
        {
            int[,] currentSubMatrix = new int[subMatrixSize, subMatrixSize];

            for (int i = 0; i < subMatrixSize; i++)
            {
                for (int j = 0; j < subMatrixSize; j++)
                {
                    currentSubMatrix[i, j] = matrix[row + i, col + j];
                }
            }

            return currentSubMatrix;
        }

        public static int CalculateSquareMatrixSum(int[,] matrix)
        {
            int sum = 0;
            int numberOfRowsAndCols = (int) Math.Sqrt(matrix.Length);
            for (int row = 0; row < numberOfRowsAndCols; row++)
            {
                for (int col = 0; col < numberOfRowsAndCols; col++)
                {
                    sum = sum + matrix[row, col];
                }
            }

            return sum;
        }
    }
}
