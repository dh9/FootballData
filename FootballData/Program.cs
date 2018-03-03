using System;

namespace FootballData
{
    class Program
    {
        static void Main(string[] args)
        {
            var matchService = new MatchService();
            Console.WriteLine(matchService.GetMatches());
        }
    }
}
