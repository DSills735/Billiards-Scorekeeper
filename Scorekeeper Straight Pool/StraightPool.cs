
public class StraightPool
{

    internal static void PlayStraightPool(string player1, string player2)
    {
        int maxScore = 0;
        int player1Score = 0;
        int player2Score = 0;
        int p1Max = 0;
        int p2Max = 0;
        int p2Wins = 0;
        int p1Wins = 0;
        Console.WriteLine("welcome to straight pool. What score would you like to play to?");
        maxScore = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        player1Score = 0;
        player2Score = 0;
        p1Max = 0;
        p2Max = 0;

        Console.WriteLine("Who is going to break? Enter 1 or 2.");
        bool validInput = false;

        //picks who will go first then exit the loop. Made into a loop for simple validation purposes. 
        while (!validInput)
        {
            int player = Convert.ToInt32(Console.ReadLine());
            if (player == 1)
            {
                StraightPoolTurn.StraightTurn(player1, player, player1Score);
                validInput = true;
                player = 2;
            }
            else if (player == 2)
            {
                StraightPoolTurn.StraightTurn(player2, player, player2Score);
                validInput = true;
                player = 1;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again. Enter 1 or 2.");
                player = Convert.ToInt32(Console.ReadLine());
            }
            bool endCondition = false;  

            //this should loop the game until the end condition is met. This will be the max score input. 
            while (!endCondition)
            {
                if (player == 1)
            {
                int roundScore = StraightPoolTurn.StraightTurn(player1, player, player1Score);
                if (roundScore > p1Max){
                        p1Max = ScoreUpdater.MaxScoreUpdater(roundScore);
                    }
                player1Score = ScoreUpdater.StraightScorekeeper(player1Score, player1, roundScore);
                endCondition = ScoreUpdater.WinCondition(player1Score, maxScore);
                player = 2;
            }
            else if (player == 2)
            {
                StraightPoolTurn.StraightTurn(player2, player, player2Score);
                int roundScore = StraightPoolTurn.StraightTurn(player2, player, player2Score);
                if (roundScore > p1Max){
                        p1Max = ScoreUpdater.MaxScoreUpdater(roundScore);
                    }
                player1Score = ScoreUpdater.StraightScorekeeper(player2Score, player2, roundScore);
                endCondition = ScoreUpdater.WinCondition(player2Score, maxScore);
                player = 1;
            }

            //Endgame winner announcement / Ask to quit or return to main menu. 
            int winner = ScoreUpdater.Winner(player1Score, player2Score);

            if(winner == 1)
                {
                    Console.WriteLine($"{player1} won with a score of {player1Score}");
                    p1Wins += 1;
                }
                else
                {
                    Console.WriteLine($"{player2} won with a score of {player2Score}");
                    p2Wins += 1;
                }
                Console.WriteLine("Play again? Y/N");
                
                

            }
            //DisplayWins();
            //CheckWins();
        }


    }
}