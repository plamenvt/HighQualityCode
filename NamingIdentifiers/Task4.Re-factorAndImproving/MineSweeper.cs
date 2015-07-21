namespace MineSweeperGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Minesweeper;

	public class MineSweeper
	{
		private static void Main()
		{
			string command;
			char[,] board = CreateBoard();
			char[,] mines = PlaceMines();
			int counter = 0;
			bool isMine = false;
			List<Points> highScores = new List<Points>(6);
			int row = 0;
			int col = 0;
			bool gameMode = true;
			const int MAX_SCORE = 35;
			bool maxResultAchieved = false;

			do
			{
				if (gameMode)
				{
                    Console.WriteLine("Let's play \"Minesweeper\". Try to find feeld with no mines in it.\n" + 
                                      "The \"top\" command shows the current standing,\n\"restart\" starts a new game,\n" +
                                      "\"exit\" quits the game.");
					PrintBoard(board);
					gameMode = false;
				}

				Console.Write("Enter row and col: ");
				command = Console.ReadLine().Trim();

				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					    int.TryParse(command[2].ToString(), out col) &&
						    row <= board.GetLength(0) && col <= board.GetLength(1))
					{
						command = "turn";
					}
				}

				switch (command)
				{
					case "top":
						PrintHighScores(highScores);
						break;

					case "restart":
						board = CreateBoard();
						mines = PlaceMines();
						PrintBoard(board);
						break;

					case "exit":
						Console.WriteLine("Bye, bye!");
						break;

					case "turn":
						if (mines[row, col] != '*')
						{
							if (mines[row, col] == '-')
							{
								PlayerMove(board, mines, row, col);
								counter++;
							}

							if (MAX_SCORE == counter)
							{
								maxResultAchieved = true;
							}
							else
							{
								PrintBoard(board);
							}
						}
						else
						{
							isMine = true;
						}

						break;

					default:
						Console.WriteLine("\nError! False command!\n");
						break;
				}

				if (isMine)
				{
					PrintBoard(mines);
					Console.Write("\nBoom! You died with {0} points. Enter your name: ", counter);
					string nickName = Console.ReadLine();
					Points result = new Points(nickName, counter);

					if (highScores.Count < 5)
					{
						highScores.Add(result);
					}
					else
					{
                        for (int i = 0; i < highScores.Count; i++)
						{
                            if (highScores[i].UserPoints < result.UserPoints)
							{
                                highScores.Insert(i, result);
                                highScores.RemoveAt(highScores.Count - 1);
								break;
							}
						}
					}

                   highScores.Sort((result1, result2) => string.Compare(
						result2.UserName, 
						result1.UserName, 
						StringComparison.Ordinal));
					highScores.Sort((result1, result2) => result2.UserPoints.CompareTo(result1.UserPoints));
					PrintHighScores(highScores);

					board = CreateBoard();
					mines = PlaceMines();
					counter = 0;
					isMine = false;
					gameMode = true;
				}

				if (maxResultAchieved)
				{
                    Console.WriteLine("\nCongratulations! You opened 35 cells!");
					PrintBoard(mines);
					Console.WriteLine("Enter your name: ");
					string name = Console.ReadLine();
					Points result = new Points(name, counter);
                    highScores.Add(result);
                    PrintHighScores(highScores);
					board = CreateBoard();
					mines = PlaceMines();
					counter = 0;
					maxResultAchieved = false;
					gameMode = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria!");
			Console.Read();
		}

		private static void PrintHighScores(List<Points> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].UserName, points[i].UserPoints);
				}

				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("No high scores to show!\n");
			}
		}

		private static void PlayerMove(char[,] field, char[,] mines, int row, int col)
		{
			char countMines = Count(mines, row, col);
			mines[row, col] = countMines;
			field[row, col] = countMines;
		}

		private static void PrintBoard(char[,] board)
		{
			int rows = board.GetLength(0);
			int cols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < cols; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}

				Console.Write("|");
				Console.WriteLine();
			}

			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateBoard()
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

		private static char[,] PlaceMines()
		{
			int rows = 5;
			int cols = 10;
			char[,] board = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					board[i, j] = '-';
				}
			}

			List<int> randomIntNumbers = new List<int>();

			while (randomIntNumbers.Count < 15)
			{
				Random random = new Random();
				int newRandom = random.Next(50);
				if (!randomIntNumbers.Contains(newRandom))
				{
					randomIntNumbers.Add(newRandom);
				}
			}

			foreach (int random in randomIntNumbers)
			{
				int col = random / cols;
				int row = random % cols;
				if (row == 0 && random != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}

				board[col, row - 1] = '*';
			}

			return board;
		}

		private static char Count(char[,] board, int row, int col)
		{
			int count = 0;
			int rows = board.GetLength(0);
			int cols = board.GetLength(1);

			if (row - 1 >= 0)
			{
				if (board[row - 1, col] == '*')
				{ 
					count++; 
				}
			}

			if (row + 1 < rows)
			{
				if (board[row + 1, col] == '*')
				{ 
					count++; 
				}
			}

			if (col - 1 >= 0)
			{
				if (board[row, col - 1] == '*')
				{ 
					count++;
				}
			}

			if (col + 1 < cols)
			{
				if (board[row, col + 1] == '*')
				{ 
					count++;
				}
			}

			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (board[row - 1, col - 1] == '*')
				{ 
					count++; 
				}
			}

			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (board[row - 1, col + 1] == '*')
				{ 
					count++; 
				}
			}

			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (board[row + 1, col - 1] == '*')
				{ 
					count++; 
				}
			}

			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (board[row + 1, col + 1] == '*')
				{ 
					count++; 
				}
			}

			return char.Parse(count.ToString());
		}
	}
}
