using System.Transactions;

Console.WriteLine("Enter the name of Player 1:");

string player1 = Console.ReadLine()!;

Console.WriteLine("Enter the name of Player 2:");

string player2 = Console.ReadLine()!;

Console.WriteLine("What score do you want to play to?");

int maxScore = Convert.ToInt32(Console.ReadLine());
int player1Score = 0;
int player2Score = 0;
int p1Max = 0;
int p2Max = 0;
int p2Wins = 0;
int p1Wins = 0;

PlayGame();
void PlayGame()
{
    Console.Clear();
    player1Score = 0;
    player2Score = 0;

    DisplayWins();

    if (p1Wins == 0 && p2Wins == 0)
    {

        Console.WriteLine("Welcome to a new game! Who is going to break? Enter 1 or 2");
    }
    else
    {
        Console.WriteLine("Welcome back! Who is going to break? Enter 1 or 2");
    }
    int breaker = Convert.ToInt32(Console.ReadLine());

    if (breaker == 2)
    {
        Player2Turn();
    }
    else
    {
        Player1Turn();
    }
}

void Player1Turn()
{

    Console.WriteLine($"{player1}, It is your turn! Enter your score when you are finished. You currently have {player1Score} points.");
    int score = Convert.ToInt32(Console.ReadLine());
    if (score > p1Max)
    {
        p1Max = score;
    }
    player1Score += score;
    Console.Clear();
    if (player1Score >= maxScore)
    {
        p1Wins++;
        Console.WriteLine($"Player 2 won with a score of {player1Score}");
        Console.WriteLine();

        DisplayScores();

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Do you want to play again? Y/N");
        string temp = Console.ReadLine()!.Trim().ToLower();

        if (temp == "y")
        {
            PlayGame();
        }
        else
        {
            Environment.Exit(0);
        }

    }
    Console.WriteLine($"{player1} scored {score}, and has a total score of {player1Score}");
    Console.WriteLine();
    Player2Turn();
}
void Player2Turn()
{

    Console.WriteLine($"{player2}, It is your turn! Enter your score when you are finished. You currently have {player2Score} points.");
    int score = Convert.ToInt32(Console.ReadLine());

    if (score > p2Max)
    {
        p2Max = score;
    }
    player2Score += score;
    Console.Clear();

    if (player2Score >= maxScore)
    {
        p2Wins++;
        Console.WriteLine($"{player2} won with a score of {player2Score}");
        Console.WriteLine();
        DisplayScores();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Do you want to play again? Y/N");
        string temp = Console.ReadLine()!.Trim().ToLower();

        if (temp == "y")
        {
            PlayGame();
        }
        else
        {
            Environment.Exit(0);
        }
    }
    Console.WriteLine($"{player2} scored {score}, and has a total score of {player2Score}");
    Console.WriteLine();
    Player1Turn();
}

void DisplayWins()
{
    Console.WriteLine($"{player1} has {p1Wins} wins.");
    Console.WriteLine($"{player2} has {p2Wins} wins.");
}
void DisplayScores()
{
    Console.WriteLine($"{player2}'s highest score was {p2Max}");
    Console.WriteLine($"{player1}'s highest score was {p1Max}");
}