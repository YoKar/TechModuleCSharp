using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ForumTopics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine();
            var dictionary = new Dictionary<string, HashSet<string>>();

            while (inputLIne!= "filter")
            {
                var tokens = inputLIne.Split(" ->,".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var positions = tokens[0];
                if (!dictionary.ContainsKey(positions))
                {
                    dictionary[positions] = new HashSet<string>();
                }
                for (int i = 1; i < tokens.Length; i++)
                {
                    dictionary[positions].Add(tokens[i]);
                }
                inputLIne = Console.ReadLine();
            }
            inputLIne = Console.ReadLine();
            var tags = inputLIne.Split(", ".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            bool filterfalse = false;
            foreach (var item in dictionary)
            {
                for (int i = 0; i < tags.Length; i++)
                {
                    if (item.Value.Contains(tags[i]))
                    {
                        filterfalse = true;
                    }
                    else
                    {
                        filterfalse = false;
                        break;
                    }
                }
                if (filterfalse)
                {
                    Console.WriteLine("{0} | #{1}",item.Key,string.Join(", #",item.Value));
                }
            }
        }
    }
}
