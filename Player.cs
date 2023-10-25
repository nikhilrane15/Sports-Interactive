using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Player> lineups = new List<Player>
        {
            new Player { PlayerId = 21, PlayerName = "Y. Chahal" },
            new Player { PlayerId = 22, PlayerName = "Bhuvneshwar Kumar" },
            new Player { PlayerId = 23, PlayerName = "Jasprit Bumrah" },
            new Player { PlayerId = 24, PlayerName = "Hardik Pandya" },
            new Player { PlayerId = 25, PlayerName = "Ravindra Jadeja" },
            new Player { PlayerId = 26, PlayerName = "Mohammed Shami" }
        };

        List<BowlingStat> bowlingStats = new List<BowlingStat>
        {
            new BowlingStat { PlayerId = 21, Wickets = 2 },
            new BowlingStat { PlayerId = 22, Wickets = 1 },
            new BowlingStat { PlayerId = 23, Wickets = 3 },
            new BowlingStat { PlayerId = 26, Wickets = 1 }
        };

        var playerWickets = bowlingStats.ToDictionary(stat => stat.PlayerId, stat => stat.Wickets);

        Console.WriteLine("Players and Wickets Taken:");
        foreach (var player in lineups)
        {
            int wickets = playerWickets.ContainsKey(player.PlayerId) ? playerWickets[player.PlayerId] : 0;
            Console.WriteLine($"{player.PlayerName}: {wickets} wickets");
        }
    }
}

class Player
{
    public int PlayerId { get; set; }
    public string PlayerName { get; set; }
}

class BowlingStat
{
    public int PlayerId { get; set; }
    public int Wickets { get; set; }
}
