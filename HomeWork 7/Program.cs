class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1;

    static void Main()
    {
        int gameStatus = 0;
        do
        {
            Console.Clear();
            PrintBoard();
            Console.WriteLine($"\nPlayer {currentPlayer}, choose a cell for your move (1-9): ");
            int choice = int.Parse(Console.ReadLine()!);

            if (choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
            {
                Console.WriteLine("Invalid choice, try again.");
                continue;
            }

            board[choice - 1] = currentPlayer == 1 ? 'X' : 'O';

            gameStatus = CheckWin();
            currentPlayer = currentPlayer == 1 ? 2 : 1;
        } while (gameStatus == 0);

        Console.Clear();
        PrintBoard();

        if (gameStatus == 1)
            Console.WriteLine($"\nPlayer {(currentPlayer == 1 ? 2 : 1)} wins!");
        else
            Console.WriteLine("\nIt's a draw!");
    }

    static void PrintBoard()
    {
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    }

    static int CheckWin()
    {
        int[,] winCombinations = {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
            {0, 4, 8}, {2, 4, 6}
        };

        foreach (int i in Enumerable.Range(0, winCombinations.GetLength(0)))
        {
            if (board[winCombinations[i, 0]] == board[winCombinations[i, 1]] &&
                board[winCombinations[i, 1]] == board[winCombinations[i, 2]])
            {
                return 1;
            }
        }

        foreach (var cell in board)
        {
            if (cell != 'X' && cell != 'O')
                return 0;
        }

        return -1;
    }
}
