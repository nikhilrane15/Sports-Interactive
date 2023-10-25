using System;
using System.Collections.Generic;

class Program
{
    public class Batsman
    {
        public string BatsmanName { get; set; }
        public int RunsScored { get; set; }
        public double StrikeRate { get; set; }
        public double BattingMomentum => RunsScored * StrikeRate;
    }

    static void Main()
    {
        List<Batsman> batsmen = new List<Batsman>
        {
            new Batsman { BatsmanName = "Virat Kohli", RunsScored = 50, StrikeRate = 78.30 },
            new Batsman { BatsmanName = "M.S. Dhoni", RunsScored = 61, StrikeRate = 58.90 },
            new Batsman { BatsmanName = "Rohit Sharma", RunsScored = 13, StrikeRate = 124.0 }
        };

        Batsman bestBatsman = FindBestBatsman(batsmen);

        Console.WriteLine("Batsman with the best batting momentum:");
        Console.WriteLine($"Name: {bestBatsman.BatsmanName}");
        Console.WriteLine($"Runs Scored: {bestBatsman.RunsScored}");
        Console.WriteLine($"Strike Rate: {bestBatsman.StrikeRate}");
        Console.WriteLine($"Batting Momentum: {bestBatsman.BattingMomentum}");
    }

    static Batsman FindBestBatsman(List<Batsman> batsmen)
    {
        Batsman bestBatsman = null;
        double highestMomentum = 0.0;

        foreach (var batsman in batsmen)
        {
            if (batsman.BattingMomentum > highestMomentum)
            {
                highestMomentum = batsman.BattingMomentum;
                bestBatsman = batsman;
            }
        }

        return bestBatsman;
    }
}
