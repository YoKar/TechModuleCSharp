using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Crossfire
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            
            
            var BroadCastList = new List<string>();
            var MeesegList = new List<string>();
            var patternMessege = @"^(?:([0-9]+) \<\-\> ([a-z0-9 A-Z]+))$";
            var patternBroadcast = @"^\D+\<\-\> ([a-zA-Z0-9]+)$";
            while (inputLine!= "Hornet is Green")
            {
                var tokens = inputLine.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                Regex regexMesege = new Regex(patternMessege);
                Regex regexBroadcast = new Regex(patternBroadcast);
                Match MatchMesege = regexMesege.Match(inputLine);
                Match MatchBroadcast = regexBroadcast.Match(inputLine);
                if (MatchMesege.Success)
                {
                    var FirstQuery = MatchMesege.Groups[1].Value.Reverse();
                    var secondQuery = tokens[2];
                    MeesegList.Add(string.Join("", FirstQuery) + " -> " + secondQuery);
                }
                else if (MatchBroadcast.Success)
                {
                    var secondQuery = new List<char>();
                    var FirstQuery = tokens[0];
                    foreach (var charr in tokens[2])
                    {
                        secondQuery.Add(charr);
                    }
                    
                    var CorectedList = new List<char>();
                    foreach (var letter in secondQuery)
                    {
                        if (char.IsUpper(letter))
                        {
                            var let = char.ToLower(letter);
                            CorectedList.Add(let);
                        }
                        else
                        {
                            var up = char.ToUpper(letter);
                            CorectedList.Add(up);
                        }
                    }

                    BroadCastList.Add(string.Join("", CorectedList)+" -> "+FirstQuery);
                }
                else
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (BroadCastList.Count>0)
            {
               
                foreach (var item in BroadCastList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (MeesegList.Count>0)
            {
                foreach (var item in MeesegList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
