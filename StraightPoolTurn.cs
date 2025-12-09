public static class StraightPoolTurn
{
    internal static int StraightTurn(string playerName, int currScore)
    {
        bool validInput = false;
        int roundScore = 0;

        Console.WriteLine($"{playerName} it is your turn. Enter your score when you are finished. You have {currScore} points.");

        while (!validInput)
        {
            string pointScored = Console.ReadLine()!;
            if (int.TryParse(pointScored, out roundScore))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please input how many points you scored.");
            }

        }
        Console.Clear();

        return roundScore;
    }

}