using System;

namespace MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix=new string[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            do
            {
                string currentLine = Console.ReadLine();

                char[] separators=new []{' '};
                string[] commandParams = currentLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (commandParams[0].ToLower()=="swap"&&commandParams.Length==5)
                {
                    try
                    {
                        int row1 = int.Parse(commandParams[1]);
                        int col1 = int.Parse(commandParams[2]);
                        int row2 = int.Parse(commandParams[3]);
                        int col2 = int.Parse(commandParams[4]);

                        bool isRow1InRange = row1 >= 0 && row1 <= rows;
                        bool isRow2InRange = row2 >= 0 && row2 <= rows;
                        bool isCol1InRange = col1 >= 0 && col1 <= cols;
                        bool isCol2InRange = col2 >= 0 && col2 <= cols;

                        if (isRow1InRange && isRow2InRange && isCol1InRange && isCol2InRange)
                        {
                            string swapVariable = String.Empty;

                            swapVariable = matrix[row1, col1];
                            matrix[row1, col1] = matrix[row2, col2];
                            matrix[row2, col2] = swapVariable;

                            //Console.WriteLine("(after swapping {0} and {1}):", matrix[row2, col2], matrix[row1, col1]);
                            PrintMatrix(matrix,rows,cols);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid input!");
                    }
                }
                else if (currentLine=="END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!"); 
                }
            } while (true);
        }

        public static void PrintMatrix(string[,] matrix,int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);

                }
                Console.WriteLine();
            }
        }
    }
}
