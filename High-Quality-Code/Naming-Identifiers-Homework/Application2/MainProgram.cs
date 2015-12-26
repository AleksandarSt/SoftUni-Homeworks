using System;
using Minesweeper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mines
{
    class MainProgram
    {
        private static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] gameField = Minesweeper.CreateGameBoard();
            char[,] mines = Minesweeper.SetMines();
            int counter = 0;
            bool isFired = false;
            List<Ranking> winners = new List<Ranking>(6);
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            const int MaxTurns = 35;
            bool areTurnsMaxed = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine(
                        "Let's go! Play the Minesweeper game. The command 'top' show the ranking," +
                        "'restart' - reset the game and command 'exit' - left the game");
                    Minesweeper.SetGameBoard(gameField);
                    isNewGame = false;
                }

                Console.Write("Enter row and col : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) &&
                        col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Minesweeper.GetRanking(winners);
                        break;
                    case "restart":
                        gameField = Minesweeper.CreateGameBoard();
                        mines = Minesweeper.SetMines();
                        Minesweeper.SetGameBoard(gameField);
                        isFired = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                Minesweeper.SwitchTurn(gameField, mines, row, col);
                                counter++;
                            }

                            if (MaxTurns == counter)
                            {
                                areTurnsMaxed = true;
                            }
                            else
                            {
                                Minesweeper.SetGameBoard(gameField);
                            }
                        }
                        else
                        {
                            isFired = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (isFired)
                {
                    Minesweeper.SetGameBoard(mines);
                    Console.WriteLine("\n Game over! You died a hero with : {0} points. Enter your nickname : ", counter);
                    string nickname = Console.ReadLine();
                    Ranking winner = new Ranking(nickname, counter);
                    int winnersLimit = 5;
                    if (winners.Count < winnersLimit)
                    {
                        winners.Add(winner);
                    }
                    else
                    {
                        for (int i = 0; i < winners.Count; i++)
                        {
                            if (winners[i].Points < winner.Points)
                            {
                                winners.Insert(i, winner);
                                winners.RemoveAt(winners.Count - 1);
                                break;
                            }
                        }
                    }

                    winners.Sort((Ranking ranking1, Ranking ranking2) => ranking2.Name.CompareTo(ranking1.Name));
                    winners.Sort((Ranking ranking1, Ranking ranking2) => ranking2.Points.CompareTo(ranking1.Points));
                    Minesweeper.GetRanking(winners);

                    gameField = Minesweeper.CreateGameBoard();
                    mines = Minesweeper.SetMines();
                    counter = 0;
                    isFired = false;
                    isNewGame = true;
                }

                if (areTurnsMaxed)
                {
                    Console.WriteLine("\ncongratulations! You find 35 cells without hurt yourself!");
                    Minesweeper.SetGameBoard(mines);
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Ranking points = new Ranking(name, counter);
                    winners.Add(points);
                    Minesweeper.GetRanking(winners);
                    gameField = Minesweeper.CreateGameBoard();
                    mines = Minesweeper.SetMines();
                    counter = 0;
                    areTurnsMaxed = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.Read();
        }
    }
}
