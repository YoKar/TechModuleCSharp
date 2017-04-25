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
         var kay = Regex.Escape(Console.ReadLine());
            var pattern = $@".*(?:{kay})(?<team1>[a-zA-Z]*)(?:{kay}).* .*(?:{kay})(?<team2>[a-zA-Z]*)(?:{kay}).* (?<firstTeamScore>[0-9]+):(?<sECONDTeamScore>[0-9]+)";
           
            Dictionary<string, int> LeageTeams = new Dictionary<string, int>();
            Dictionary<string, int> TopScoredTeams = new Dictionary<string, int>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine=="final")
                {
                    break;
                }
                var match = Regex.Match(inputLine,pattern);
                if (match.Success)
                {
                    var firstTeam =new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                    var secondTeam =new string( match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                    var firstTeamGoals = int.Parse(match.Groups["firstTeamScore"].Value);
                    var secondTeamGoals = int.Parse(match.Groups["sECONDTeamScore"].Value);
                    if (!LeageTeams.ContainsKey(firstTeam))
                    {
                        LeageTeams[firstTeam] = 0;
                    }
                    if (!LeageTeams.ContainsKey(secondTeam))
                    {
                        LeageTeams[secondTeam] = 0;
                    }
                    if (firstTeamGoals>secondTeamGoals)
                    {
                        LeageTeams[firstTeam] += 3;
                    }
                    if (firstTeamGoals==secondTeamGoals)
                    {
                        LeageTeams[firstTeam] += 1;
                        LeageTeams[secondTeam] += 1;
                    }
                    if (firstTeamGoals < secondTeamGoals)
                    {
                        LeageTeams[secondTeam] += 3;
                    }
                   
                    if (!TopScoredTeams.ContainsKey(firstTeam))
                    {
                        TopScoredTeams[firstTeam] = 0;
                    }
                    if (!TopScoredTeams.ContainsKey(secondTeam))
                    {
                        TopScoredTeams[secondTeam] = 0;
                    }
                    TopScoredTeams[firstTeam] += firstTeamGoals;
                    TopScoredTeams[secondTeam] += secondTeamGoals;
                }
             
               
            }
           var orderedDic= LeageTeams.OrderByDescending(k => k.Value).ThenBy(k => k.Key).ToDictionary(k => k.Key, k => k.Value);
           var orderedGoals= TopScoredTeams.OrderByDescending(k => k.Value).ThenBy(k => k.Key).ToDictionary(k => k.Key, k => k.Value).Take(3);
            var count = 1;
            Console.WriteLine("League standings:");
            foreach (var item in orderedDic)
            {
               
                Console.WriteLine($"{count++}. {item.Key} {item.Value}");
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in orderedGoals)
            {
              
                Console.WriteLine($"- {item.Key} -> {item.Value}");
            }
        }
    }
}
