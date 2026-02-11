using Microsoft.Data.Sqlite;
using Spectre.Console;
public class Program
{
    static String connString = "Data Source = poolHistory.db";
    internal static void Main(string[] args)
    {
        using (var connection = new SqliteConnection(connString))
        {
            connection.Open();
            var tableCommand = connection.CreateCommand();
            tableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS Pool_History(
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        PlayerName TEXT UNIQUE,
                                        Wins INTEGER)";
            tableCommand.ExecuteNonQuery();
            connection.Close();
        }
        
        Initialization();
    }

    internal static void Initialization()
    {
        Console.WriteLine("Welcome to the pool tracker. Please enter the player names.");
        Console.WriteLine("Enter the name of Player 1:");

        string player1 = Console.ReadLine()!;

        Console.WriteLine("Enter the name of Player 2:");

        string player2 = Console.ReadLine()!;

        Console.Clear();
        MainMenu(player1, player2);
    }

    internal static void MainMenu(string player1, string player2)
    {
        Console.Clear();
        AnsiConsole.MarkupLine($"{player1} and {player2}, what game do you want to play? Pick an option from below.");
        AnsiConsole.MarkupLine("[green]1. Play Straight pool[/]");
        AnsiConsole.MarkupLine("[red]2. Play snooker[/]");
        AnsiConsole.MarkupLine("[blue]3. View History[/]");
        AnsiConsole.MarkupLine("[maroon]4. Exit[/]");

        string userInput = Console.ReadLine()!;
        bool validInput = false;
        int p2Wins = 0;
        int p1Wins = 0;

        while (!validInput)
        {

            if (userInput == "1")
            {
                StraightPool.PlayStraightPool(player1, player2, p2Wins, p1Wins);
                validInput = true;
                Console.Clear();
            }
            else if (userInput == "2")
            {
                Snooker.PlaySnooker(player1, player2);
                //userInput = Console.ReadLine()!;
            }
            else if(userInput == "3")
            {
                ScoreHistory.ViewHistory(player1, player2);
            }
            else if(userInput == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter an option from above.");
                userInput = Console.ReadLine()!;
            }

        }
    }
}
