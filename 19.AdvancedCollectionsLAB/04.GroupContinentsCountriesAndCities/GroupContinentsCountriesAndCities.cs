using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GroupContinentsCountriesAndCities
{
    class GroupContinentsCountriesAndCities
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var Global = new SortedDictionary<string, SortedDictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                var tokens = word.Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];
                if (!Global.ContainsKey(continent))
                {
                    Global[continent] = new SortedDictionary<string, List<string>>();
                }
                if (!Global[continent].ContainsKey(country))
                {
                    Global[continent][country] = new List<string>();
                }
                if (!Global[continent][country].Contains(city))
                {
                    Global[continent][country].Add(city);
                }
                
            }
            foreach (var item in Global)
            {
                Console.WriteLine("{0}:",item.Key);
                foreach (var Part in item.Value)
                {
                    Part.Value.Sort();
                    Console.WriteLine("{0} -> {1}",Part.Key,string.Join(", ",Part.Value));
                }
            }
        }
    }
}
