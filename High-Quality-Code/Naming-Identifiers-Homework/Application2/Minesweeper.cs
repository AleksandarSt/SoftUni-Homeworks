using Minesweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mines
{
    public class Minesweeper
    {
        public static void GetRanking(List<Ranking> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Ranking!\n");
            }
        }

        public static void SwitchTurn(char[,] board, char[,] mines, int row, int column)
        {
            char numberOfMines = GetMinesNumber(mines, row, column);
            mines[row, column] = numberOfMines;
            board[row, column] = numberOfMines;
        }

        public static void SetGameBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public static char[,] CreateGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }


        public static char[,] SetMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] board = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int newMine = random.Next(50);
                if (!mines.Contains(newMine))
                {
                    mines.Add(newMine);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / columns;
                int row = mine % columns;
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        public static void CalculatePoints(char[,] board)
        {
            int columns = board.GetLength(0);
            int rows = board.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char minesNumber = GetMinesNumber(board, i, j);
                        board[i, j] = minesNumber;
                    }
                }
            }
        }

        public static char GetMinesNumber(char[,] board, int currentRow, int currentColumn)
        {
            int minesCounter = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (board[currentRow - 1, currentColumn] == '*')
                {
                    minesCounter++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (board[currentRow + 1, currentColumn] == '*')
                {
                    minesCounter++;
                }
            }

            if (currentColumn - 1 >= 0)
            {
                if (board[currentRow, currentColumn - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if (currentColumn + 1 < cols)
            {
                if (board[currentRow, currentColumn + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn - 1 >= 0))
            {
                if (board[currentRow - 1, currentColumn - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn + 1 < cols))
            {
                if (board[currentRow - 1, currentColumn + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColumn - 1 >= 0))
            {
                if (board[currentRow + 1, currentColumn - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColumn + 1 < cols))
            {
                if (board[currentRow + 1, currentColumn + 1] == '*')
                {
                    minesCounter++;
                }
            }

            return char.Parse(minesCounter.ToString());
        }
    }
}