using System;
using System.Linq;

namespace CollectTheCoins
{
    class CollectTheCoins
    {
        static void Main()
        {
            const int numberOfRows = 4;
            const char coin = '$';

            string currentLine;
            string[] lines=new string[numberOfRows];

            char[][] board = new char[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                currentLine = Console.ReadLine();

                board[row] = currentLine.ToCharArray();
            }

            string movements = Console.ReadLine();
            
            int coinsCount = 0;
            int wallHitsCount = 0;
            int currentRow = 0;
            int currentCol = 0;

            if (board[0][0]== coin)
            {
                coinsCount++;
            }

            for (int i = 0; i < movements.Length; i++)
            {
                char currentMove = movements[i];

                if (currentMove == 'V' && currentRow + 1 < numberOfRows &&
                    currentCol < board[currentRow + 1].Length)
                {
                    currentRow++;
                    coinsCount = CoinsCount(board, currentRow, currentCol, coin, coinsCount);
                }
                else if (currentMove == '>' && currentCol + 1 < board[currentRow].Length)
                {
                    currentCol++;
                    coinsCount = CoinsCount(board, currentRow, currentCol, coin, coinsCount);
                }
                else if (currentMove == '<' && currentCol - 1 >= 0)
                {
                    currentCol--;
                    coinsCount = CoinsCount(board, currentRow, currentCol, coin, coinsCount);
                }
                else if (currentMove == '^' && currentRow - 1 >= 0 &&
                         currentCol < board[currentRow - 1].Length)
                {
                    currentRow--;
                    coinsCount = CoinsCount(board, currentRow, currentCol, coin, coinsCount);
                }
                else
                {
                    wallHitsCount++;
                }
            }

            Console.WriteLine("Coins collected: {0}",coinsCount);
            Console.WriteLine("Wall hit: {0}",wallHitsCount);
        }

        public static int CoinsCount(char[][] board, int currentRow, int currentCol, char coin, int coinsCount)
        {
            if (board[currentRow][currentCol] == coin)
            {
                coinsCount++;
            }
            return coinsCount;
        }
    }
}
