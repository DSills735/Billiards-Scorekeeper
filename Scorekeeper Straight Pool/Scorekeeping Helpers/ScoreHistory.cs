using Microsoft.Data.Sqlite;

public static class ScoreHistory
{
    static String connString = "Data Source = poolHistory.db";
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

    internal static void AddToHistory(string name)
    {
        using (var connection = new SqliteConnection(connString))
        {
            connection.Open();
            var tableCommand = connection.CreateCommand();
            tableCommand.CommandText = @$"INSERT INTO Pool_History (PlayerName, Wins)
                                        VALUES('{name}', 1)
                                        ON CONFLICT(PlayerName)
                                        DO UPDATE SET Wins = Wins + 1";
            tableCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
    internal static void ViewHistory(string p1, string p2)
    {
        using (var connection = new SqliteConnection(connString))
        {
            connection.Open();
            var tableCommand = connection.CreateCommand();
            tableCommand.CommandText = "SELECT * From Pool_History";
            List<PoolHistory> tableData = new();

            SqliteDataReader reader = tableCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tableData.Add(
                        new PoolHistory
                        {
                            Id = reader.GetInt32(0),
                            PlayerName = reader.GetString(1),
                            Wins = reader.GetInt32(2)
                        }); ;

                }
            }
            else
            {
                Console.WriteLine("No History found.");
            }
            connection.Close();

            Console.WriteLine("-----------------------------------------------------------");

            foreach (var hist in tableData)
            {
                Console.WriteLine($"{hist.Id} - {hist.PlayerName}: Wins: {hist.Wins}");
            }
            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Press Q to return to the menu.");
            string response = Console.ReadLine()!;

            bool userInput = false;

            while (!userInput)
            {


                if (response.Trim().ToLower() == "q")
                {
                    Program.MainMenu(p1, p2);
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}