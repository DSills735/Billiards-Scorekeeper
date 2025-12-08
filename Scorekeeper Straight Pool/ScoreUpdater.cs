public static class ScoreUpdater
{
    //update the max "break" or score in one turn. 
    internal static int MaxScoreUpdater(int score)
    {
       int max = score;
       return score;
    }
    
    //Update the score of the game
    internal static int StraightScorekeeper(int playerScore, string playerName, int score)
    {
        playerScore += score;
        Console.WriteLine($"{playerName} scored {score}. You have {playerScore} points.");
        return playerScore;
    }

//Check to see if a player met the defined win condition
    internal static bool WinCondition(int score, int maxScore)
    {
        if(score >= maxScore)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    internal static int Winner(int p1Score, int p2Score)
{   
    if(p2Score > p1Score)
        {
         return 2;   
        }
        else
        {
        return 1;
        }
}
}