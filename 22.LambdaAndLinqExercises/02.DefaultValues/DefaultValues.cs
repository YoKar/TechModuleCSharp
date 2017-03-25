using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> DicStrings = new Dictionary<string, string>();

            var inputLIne = Console.ReadLine();
            while (inputLIne!="end")
            {
                var tokens = inputLIne.Split(" ->".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var word1 = tokens[0];
                var word2 = tokens[1];
                DicStrings[word1]=word2;
                inputLIne = Console.ReadLine();
            }
            inputLIne = Console.ReadLine();

            Dictionary<string, string> UnchangeDic = DicStrings.Where(x => x.Value != "null").OrderByDescending(x=>x.Value.Length).ToDictionary(x=> x.Key , x => x.Value);
            Dictionary<string, string> ChangegValues = DicStrings.Where(x => x.Value == "null").ToDictionary(x => x.Key, x => inputLIne);
            foreach (var item in UnchangeDic)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
            foreach (var item in ChangegValues)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
