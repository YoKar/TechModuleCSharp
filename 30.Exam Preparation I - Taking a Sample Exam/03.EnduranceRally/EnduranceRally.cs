using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ');
            var zones = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var CheckPointIndexes = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            foreach (var participant in names)
            {
                decimal fuil = participant[0];
                for (int i = 0; i < zones.Length; i++)
                {
                    var zonesIndex = zones[i];
                    var chekpoint = CheckPointIndexes.Contains(i);
                    if (chekpoint)
                    {
                        fuil += zones[i];
                    }
                    else
                    {
                        fuil -= zones[i];
                    }
                    if (fuil<=0|| i == zones.Length - 1)
                    {
                        if (fuil <= 0)
                        {
                            Console.WriteLine("{0} - reached {1}", participant, i);
                            break;
                        }
                        if (i == zones.Length - 1)
                        {
                            Console.WriteLine("{0} - fuel left {1:f2}", participant, fuil);
                        }
                        
                       
                    }
                    
                }
            }
            
        }

    }
}
