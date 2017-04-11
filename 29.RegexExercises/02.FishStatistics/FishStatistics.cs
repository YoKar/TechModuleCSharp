using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.FishStatistics
{
    class FishStatistics
    {
        static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine();
            var pattern = @"(>*)<{1}(\(+)('|-|x){1}>{1}";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(inputLIne);
            var counter = 1;
            foreach (Match groups in match)
            {
                var TailType = string.Empty;
                var BodyType = string.Empty;
                var Status = string.Empty;
                Console.WriteLine("Fish {0}: {1}",counter,groups.Value);
                if (groups.Groups[1].Length<=1)
                {
                    if (groups.Groups[1].Length <= 0)
                    {
                        TailType = "None";
                    }
                    else
                    {
                        TailType = "Short";
                    }
                   
                }
                else if (groups.Groups[1].Length > 1&& groups.Groups[1].Length<=5)
                {
                    TailType = "Medium";
                }
                else if (groups.Groups[1].Length > 5)
                {
                    TailType = "Long";
                }
                if (TailType=="None")
                {
                    Console.WriteLine("  Tail type: {0}", TailType);
                }
                else
                {
                    Console.WriteLine("  Tail type: {0} ({1} cm)", TailType, groups.Groups[1].Length * 2);
                }
                if (groups.Groups[2].Length > 10)
                {
                    BodyType = "Long";
                }
                else if (groups.Groups[2].Length <= 10&& groups.Groups[2].Length > 5)
                {
                    BodyType = "Medium";
                }
                else
                {
                    BodyType = "Short";
                }
                Console.WriteLine("  Body type: {0} ({1} cm)",BodyType,groups.Groups[2].Length*2);
                if (groups.Groups[3].Value=="\'")
                {
                    Status = "Awake";
                }
                else if (groups.Groups[3].Value == "-")
                {
                    Status = "Asleep";
                }
                else if (groups.Groups[3].Value == "x")
                {
                    Status = "Dead";
                }
                Console.WriteLine("  Status: {0}",Status);
                counter++;
            }
            if (match.Count==0)
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
