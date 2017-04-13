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
            var InputNames = Console.ReadLine().Split(',').Select(a => a.Trim());
            var InputSongs = Console.ReadLine().Split(',').Select(a => a.Trim());
            var NameAndSongs = Console.ReadLine();
            Dictionary<string, HashSet<string>> Dictionaryawards = new Dictionary<string, HashSet<string>>();
            while (NameAndSongs!="dawn")
            {
                var tokens = NameAndSongs.Split(',').Select(a => a.Trim()).ToArray();
                var name = tokens[0];
                var song = tokens[1];
                var award = tokens[2];
                if (InputNames.Contains(name)&&InputSongs.Contains(song))
                {
                    if (!Dictionaryawards.ContainsKey(name))
                    {
                        Dictionaryawards[name] = new HashSet<string>();
                    }
                    Dictionaryawards[name].Add(award);
                }
                NameAndSongs = Console.ReadLine();
            }
            var OrderedDic = Dictionaryawards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in OrderedDic)
            {
                Console.WriteLine("{0}: {1} awards",item.Key,item.Value.Count);
                foreach (var value in item.Value.OrderBy(a=>a))
                { 
                    Console.WriteLine("--"+value);
                }
            }
            if (OrderedDic.Values.Count==0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
