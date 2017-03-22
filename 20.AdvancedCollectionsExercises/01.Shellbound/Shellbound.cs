using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var regionSize = Console.ReadLine();
            var shellDic = new Dictionary<string, List<int>>();
            while (regionSize!= "Aggregate")
            {
                var tokens = regionSize.Split(' ');
                var region = tokens[0];
                var size =int.Parse(tokens[1]);
                if (!shellDic.ContainsKey(region))
                {
                    shellDic[region] = new List<int>();
                }
                if (!shellDic[region].Contains(size))
                {
                    shellDic[region].Add(size);
                }
                regionSize = Console.ReadLine();
            }
           
            foreach (var itemPart in shellDic)
            {
                Console.Write("{0} -> {1} ({2})",itemPart.Key,string.Join(", ",itemPart.Value), itemPart.Value.Sum()-(int)(itemPart.Value.Average()));
                Console.WriteLine();
            }
        }
    }
}
