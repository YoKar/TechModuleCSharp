using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_TheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            var events = Console.ReadLine();
            Dictionary<string, Dictionary<string, SortedSet<string>>> DictionaryEvenets = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            while (events!= "Time for Code")
            {
                if (!events.Contains("#"))
                {
                    continue;
                }
                var tokens = events.Split("#".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();
                var ID = tokens[0];
                var secondTokens = tokens[1].Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();
                var Event = secondTokens[0];
                if (!DictionaryEvenets.ContainsKey(ID))
                {
                    DictionaryEvenets[ID] = new Dictionary<string, SortedSet<string>>();
                }
                
                for (int i = 1; i < secondTokens.Length; i++)
                {
                    if (!DictionaryEvenets[ID].ContainsKey(Event))
                    {
                        DictionaryEvenets[ID][Event] =new SortedSet<string>();
                    }
                    DictionaryEvenets[ID][Event].Add(secondTokens[i]);
                }
                events = Console.ReadLine();
            }
           
            foreach (var item in DictionaryEvenets)
            {
                foreach (var Part in item.Value)
                {
                    Console.WriteLine("{0} - {1}",Part.Key,Part.Value.Count);
                    foreach (var count in Part.Value)
                    {
                        Console.WriteLine(count);
                    }
                }
            }
        }
    }
}
