using System.Transactions;


public static class Program
{

    static void Main(string[] args)
    {
        MainMenu();
    }

    internal static void MainMenu()
    {
        Console.WriteLine("Welcome to the pool tracker. Please enter the player names.");
        Console.WriteLine("Enter the name of Player 1:");

        string player1 = Console.ReadLine()!;

        Console.WriteLine("Enter the name of Player 2:");

        string player2 = Console.ReadLine()!;

        Console.Clear();

        Console.WriteLine($"{player1} and {player2}, what game do you want to play? Pick an option from below.");
        Console.WriteLine("1. Play Straight pool");
        Console.WriteLine("2. Play snooker -- NOT ACTIVE YET");

        string userInput = Console.ReadLine()!;
        bool validInput = false;

        while (!validInput)
        {

        if (userInput == "1"){
            StraightPool.PlayStraightPool(player1, player2);
            validInput = true;
            Console.Clear();
        }
        else if(userInput == "2")
            {
                
                //This will lead to snooker eventually.
            }
            else
            {
                Console.WriteLine("Please enter an option from above.");
                userInput = Console.ReadLine()!;
            }

        }
    }
    }
    