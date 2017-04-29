using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(',').Select(a => a.Trim()).ToList();
            var ValindSongs = Console.ReadLine().Split(',').Select(a => a.Trim()).ToList();
            Dictionary<string, HashSet<string>> NameAward = new Dictionary<string, HashSet<string>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine=="dawn")
                {
                    break;
                }
                var tokens = inputLine.Split(',').Select(a => a.Trim()).ToList();
                var name = tokens[0];
                var song = tokens[1];
                var award = tokens[2];
                if (participants.Contains(name))
                {
                    if (ValindSongs.Contains(song))
                    {
                        if (!NameAward.ContainsKey(name))
                        {
                            NameAward[name] = new HashSet<string>();
                        }
                        
                            NameAward[name].Add(award);
                        
                       
                    }
                    
                }
            }
           var orderedDic= NameAward.OrderByDescending(a => a.Value.Count).ThenBy(a=>a.Key).ToDictionary(a=>a.Key,a=>a.Value);
            if (orderedDic.Count==0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in orderedDic)
                {

                    Console.WriteLine("{0}: {1} awards", item.Key, item.Value.Count());

                    foreach (var part in item.Value.OrderBy(a=>a))
                    {
                        Console.WriteLine("--{0}", string.Join("", part));
                    }

                }
            }
           
        }
    }
}
