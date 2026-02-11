using System.ComponentModel.DataAnnotations;

public class Snooker
{
    internal static void PlaySnooker(string player1, string player2)
    {
        int player1Score = 0;
        int player2Score = 0;
        int p1Max = 0;
        int p2Max = 0;
        int p2Wins = 0;
        int p1Wins = 0;

        Console.WriteLine("Welcome to Snooker. Who is going to break? Enter 1 or 2.");
        bool validInput = false;

        //picks who will go first then exit the loop
        while (!validInput)
        {
            int player = Convert.ToInt32(Console.ReadLine());
            if (player == 1)
            {
                validInput = true;

            }
            else if (player == 2)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again. Enter 1 or 2.");
                player = Convert.ToInt32(Console.ReadLine());
            }
            bool gameOver = false;
            int winner = 0;
            while (!gameOver)
            {
                if (player == 1)
                {
                    
                    int temp = SnookerTurn.SnookerBreak(player1, player1Score);
                    if (temp > -10000)
                    {
                        player1Score += temp;
                        Console.Clear();
                        Console.WriteLine($"{player1} scored {temp} points, and now has {player1Score} points.");
                        if(temp > p1Max)
                        {
                            p1Max = temp;
                        }
                        player = 2;
                    }
                    else if (temp == -10000)
                    {
                        gameOver = true;
                        winner = ScoreUpdater.Winner(player1Score, player2Score);
                    }
                    
                }
                else if (player == 2)
                {
                    
                    int temp = SnookerTurn.SnookerBreak(player2, player2Score);
                    if (temp > -10000)
                    {
                        player2Score += temp;
                        Console.Clear();
                        Console.WriteLine($"{player2} scored {temp} points, and now has {player2Score} points.");
                        
                        if(temp > p2Max)
                        {
                            p2Max = temp;
                        }
                        player = 1;
                    }
                    else if (temp == -10000)
                    {
                        gameOver = true;
                        winner = ScoreUpdater.Winner(player1Score, player2Score);
                    }
                }
            }
            if (winner == 1)
            {
                Console.WriteLine($"{player1} won with a score of {player1Score} to {player2Score}.");
                ScoreHistory.AddToHistory(player1);
                p1Wins += 1;
            }
            else
            {
                Console.WriteLine($"{player2} won with a score of {player2Score} to {player1Score}.");
                ScoreHistory.AddToHistory(player2);
                p2Wins += 1;
            }
            
            ScoreHistory.DisplayWins(player1, player2, p1Wins, p2Wins);
            ScoreHistory.DisplayScores(player1, player2, p1Max, p2Max);

            Console.WriteLine("Please choose an option from below:");
            Console.WriteLine("\t1: Play Snooker again?");
            Console.WriteLine("\t2: Play another game.");
            Console.WriteLine("\t3: Quit the application.");

            string response = Console.ReadLine()!;
            validInput = false;
            while(!validInput){
            if (response == "1")
            {
                PlaySnooker(player1, player2);
                validInput = true;
            }
            else if(response == "2")
            {
                Program.MainMenu(player1, player2);
                validInput = true;
            }
            else if(response == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again.");
                response = Console.ReadLine()!;
            }
            }

        }
    }
}