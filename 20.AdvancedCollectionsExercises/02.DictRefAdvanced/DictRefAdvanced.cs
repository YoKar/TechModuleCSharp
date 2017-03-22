using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var dicitionery = new Dictionary<string, List<int>>();
            while (inputLine!="end")
            {
                var tokens = inputLine.Split(" ->,".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var names = tokens[0];
                var num = 0;
                if (int.TryParse(tokens[1],out num))
                {
                    if (!dicitionery.ContainsKey(names))
                    {
                        dicitionery[names] = new List<int>();
                    }
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        int numbers = int.Parse(tokens[i]);
                        dicitionery[names].Add(numbers);
                    }
                }
                else
                {
                    if (dicitionery.ContainsKey(tokens[1]))
                    {

                        dicitionery[tokens[0]] = new List<int>(dicitionery[tokens[1]]);
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var itemPart in dicitionery)
            {
                Console.WriteLine("{0} === {1}",itemPart.Key,string.Join(", ",itemPart.Value));
            }
        }
    }
}
