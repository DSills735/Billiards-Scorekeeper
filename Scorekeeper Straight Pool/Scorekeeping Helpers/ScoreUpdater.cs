using Spectre.Console;
public static class ScoreUpdater
{
    //update the max "break" or score in one turn. 
    internal static int MaxScoreUpdater(int score)
    {
        int max = score;
        return score;
    }

    //Check to see if a player met the defined win condition
    public static bool WinCondition(int score, int maxScore)
    {
        if (score >= maxScore)
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
        if (p2Score > p1Score)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }
    internal static void ScoreDisplay(int p1Score, int p2Score, string p1Name, string p2Name, int maxScore)
    {
        if (p1Score > p2Score)
        {
            var chart = new BarChart()
                .WithMaxValue(maxScore)
                .AddItem(p1Name, p1Score, Color.Green)
                .AddItem(p2Name, p2Score, Color.Maroon);
            AnsiConsole.Write(chart);
        }
        else
        {
            var chart = new BarChart()
                .WithMaxValue(maxScore)
                .AddItem(p2Name, p2Score, Color.Green)
                .AddItem(p1Name, p1Score, Color.Maroon);
            AnsiConsole.Write(chart);
        }
    }

}