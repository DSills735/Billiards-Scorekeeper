
public class StraightPool
{
        
    internal static void PlayStraightPool(string player1, string player2, int p2Wins, int p1Wins)
    {
        int maxScore = 0;
        int player1Score = 0;
        int player2Score = 0;
        int p1Max = 0;
        int p2Max = 0;
        

        Console.WriteLine("Welcome to Straight Pool. What score would you like to play to?");
        maxScore = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        player1Score = 0;
        player2Score = 0;
        p1Max = 0;
        p2Max = 0;

        Console.WriteLine("Who is going to break? Enter 1 or 2.");
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
            bool endCondition = false;

            //this will loop the game until the end condition (max score) is met or exceeded. This will be the max score input. 
            while (!endCondition)
            {
                if (player == 1)
                {
                    int roundScore = StraightPoolTurn.StraightTurn(player1, player1Score);
                    if (roundScore > p1Max)
                    {
                        p1Max = ScoreUpdater.MaxScoreUpdater(roundScore);
                    }
                    player1Score += roundScore;
                    Console.WriteLine($"{player1} scored {roundScore}. The score is now {player1}: {player1Score} to {player2}: {player2Score}");
                    Console.WriteLine();
                    ScoreUpdater.ScoreDisplay(player1Score, player2Score, player1, player2, maxScore);
                    Console.WriteLine();
                    endCondition = ScoreUpdater.WinCondition(player1Score, maxScore);
                    player = 2;
                }
                else if (player == 2)
                {
                    int roundScore = StraightPoolTurn.StraightTurn(player2, player2Score);
                    if (roundScore > p2Max)
                    {
                        p2Max = ScoreUpdater.MaxScoreUpdater(roundScore);
                    }
                    player2Score += roundScore;
                    Console.WriteLine($"{player2} scored {roundScore}. The score is now {player1}: {player1Score} to {player2}: {player2Score}");
                    Console.WriteLine();
                    ScoreUpdater.ScoreDisplay(player1Score, player2Score, player1, player2, maxScore);
                    Console.WriteLine();
                    endCondition = ScoreUpdater.WinCondition(player2Score, maxScore);
                    player = 1;
                }
            }
            //Endgame winner announcement / Ask to quit or return to main menu. 
            int winner = ScoreUpdater.Winner(player1Score, player2Score);

            if (winner == 1)
            {
                Console.WriteLine($"{player1} won with a score of {player1Score} to {player2Score}.");
                Console.WriteLine();
                ScoreHistory.AddToHistory(player1);
                p1Wins += 1;
            }
            else
            {
                Console.WriteLine($"{player2} won with a score of {player2Score} to {player1Score}.");
                Console.WriteLine();
                ScoreHistory.AddToHistory(player2);
                p2Wins += 1;
            }
            ScoreHistory.DisplayWins(player1, player2, p1Wins, p2Wins);
            ScoreHistory.DisplayScores(player1, player2, p1Max, p2Max);

            Console.WriteLine("Please choose an option from below:");
            Console.WriteLine("\t1: Play Straight Pool again?");
            Console.WriteLine("\t2: Return to the main menu.");
            Console.WriteLine("\t3: Quit the application.");

            string response = Console.ReadLine()!;
            validInput = false;
            while(!validInput){
            if (response == "1")
            {
                PlayStraightPool(player1, player2, p2Wins, p1Wins);
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