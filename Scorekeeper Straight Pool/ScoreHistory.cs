public static class ScoreHistory
{
     internal static void DisplayWins()
    {
        Console.WriteLine($"{player1} has {p1Wins} wins.");
        Console.WriteLine($"{player2} has {p2Wins} wins.");
    }
    internal static void DisplayScores()
    {
        Console.WriteLine($"{player2}'s highest score was {p2Max}");
        Console.WriteLine($"{player1}'s highest score was {p1Max}");
    }
}