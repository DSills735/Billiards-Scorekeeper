
public class SnookerTurn
{
    internal static int SnookerBreak(string playerName, int currScore)
    {
        Console.WriteLine($"{playerName} it is your turn. Enter your score when finished. Your current score is {currScore}.");
        Console.WriteLine("If the game is over, press \"f\"");
        string response = Console.ReadLine()!;
        bool validInput = false;
        while (!validInput)
        {
            if (int.TryParse(response, out currScore))
            {
                
                return currScore;
            }
            else if (response.Trim().ToLower() == "f")
            {
                
                validInput = true;
                return -10000;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter either a whole number or 'f'");
                response = Console.ReadLine()!;
            }

        }
        return currScore;
    }
}