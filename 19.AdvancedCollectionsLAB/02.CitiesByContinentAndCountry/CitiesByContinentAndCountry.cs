using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var ContContrCity = new Dictionary<string ,Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                var words = Console.ReadLine();
                var tokens = words.Split(' ');
                var Continent = tokens[0];
                var Countrys = tokens[1];
                var Cityes = tokens[2];
                if (!ContContrCity.ContainsKey(Continent))
                {

                    ContContrCity[Continent] = new Dictionary<string, List<string>>();

                }
                
                if (!ContContrCity[Continent].ContainsKey(Countrys))
                {
                    
                    ContContrCity[Continent][Countrys] = new List<string>();
                }
                
                
                    ContContrCity[Continent][Countrys].Add(Cityes);
                
            }
            foreach (var continet in ContContrCity)
            {
                Console.WriteLine("{0}:",continet.Key);
                foreach (var country in continet.Value)
                {
                    Console.Write("{0} -> {1}",country.Key, string.Join(", ", country.Value));
                    Console.WriteLine();
                    
                   
                }
          
            }
        }
    }
}
