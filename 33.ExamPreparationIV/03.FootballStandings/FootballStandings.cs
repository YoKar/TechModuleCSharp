using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.FootballStandings
{
    class FootballStandings
    {
        static void Main(string[] args)
        {
            var theKay = Console.ReadLine();
            var pattern = string.Empty;
            if (theKay.Contains('?')|| theKay.Contains('@')|| theKay.Contains('#')|| theKay.Contains('+')|| theKay.Contains('-')|| theKay.Contains('$')|| theKay.Contains('_')|| theKay.Contains('/')|| theKay.Contains('%')|| theKay.Contains('*'))
            {
                var SecondKay = string.Empty;
                foreach (var item in theKay)
                {
                    SecondKay += @"\" + item;
                }
                 pattern = SecondKay + "+([A-z]+)" + SecondKay;
            }
            else
            {
                pattern = theKay + "+([A-z]+)" + theKay;
            }
            var ScorePatern = @"[0-9]+\:[0-9]+";
            Regex score = new Regex(ScorePatern);
            Regex regex = new Regex(pattern);
            Dictionary<string, int> Goals = new Dictionary<string, int>();

            Dictionary<string, int> TheRating = new Dictionary<string, int>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "final")
                {
                    break;
                }
                MatchCollection matchTeams = regex.Matches(inputLine);
                Match TheScore = score.Match(inputLine);
                var tokens = TheScore.Groups[0].Value.Split(':');
                var RightTeam = int.Parse(tokens[0]);
                var LeftTeam = int.Parse(tokens[1]);
                var FirstTeam = string.Empty;
                var SecondTeam = string.Empty;
                var listOfTeams = new List<string>();
                foreach (Match item in matchTeams)
                {
                    listOfTeams.Add(item.Groups[0].Value.Trim(theKay.ToArray()));
                }
                var stTram = listOfTeams[0].ToList();
                var SecTam = listOfTeams[1].ToList();
                stTram.Reverse();
                SecTam.Reverse();
                FirstTeam =string.Join("", stTram).ToUpper();
                SecondTeam =string.Join("", SecTam).ToUpper();
                if (!TheRating.ContainsKey(FirstTeam))
                {
                    TheRating[FirstTeam] = 0;
                }
                if (!TheRating.ContainsKey(SecondTeam))
                {
                    TheRating[SecondTeam] = 0;
                }
                if (!Goals.ContainsKey(FirstTeam))
                {
                    Goals[FirstTeam] = 0;
                }
                if (!Goals.ContainsKey(SecondTeam))
                {
                    Goals[SecondTeam] = 0;
                }
                if (RightTeam > LeftTeam)
                {
                    TheRating[FirstTeam] += 3;

                }
                else if (LeftTeam > RightTeam)
                {
                    TheRating[SecondTeam] += 3;

                }
                else if (RightTeam == LeftTeam)
                {
                    TheRating[FirstTeam] += 1;
                    TheRating[SecondTeam] += 1;
                }
                Goals[FirstTeam] += RightTeam;
                Goals[SecondTeam] += LeftTeam;


            }
            TheRating = TheRating.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            Goals = Goals.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("League standings:");
            var counter = 1;
            foreach (var item in TheRating)
            {
                Console.WriteLine("{0}. {1} {2}", counter, item.Key, item.Value);
                counter++;
            }
            Console.WriteLine("Top 3 scored goals:");
            var count = 3;
            foreach (var parts in Goals)
            {
                if (count==0)
                {
                    break;
                }
                Console.WriteLine("- {0} -> {1}",parts.Key,parts.Value);
                count--;
            }
        }
    }
}
