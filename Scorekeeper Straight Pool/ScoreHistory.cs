
public static class ScoreHistory
{
     internal static void DisplayWins(string player1, string player2, int p1Wins, int p2Wins)
    {
        Console.WriteLine($"{player1} has {p1Wins} wins.");
        Console.WriteLine($"{player2} has {p2Wins} wins.");
        Console.WriteLine("_______________________________________________");
        Console.WriteLine();
    }
    internal static void DisplayScores(string player1, string player2, int p1Max, int p2Max)
    {
        Console.WriteLine($"{player2}'s highest score was {p2Max}");
        Console.WriteLine($"{player1}'s highest score was {p1Max}");
        Console.WriteLine("_______________________________________________");
        Console.WriteLine();
    }
}