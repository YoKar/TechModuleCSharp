using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var power = hornets.Sum();
            var firstHorn = 0;
            for (int i = 0; i < beehives.Count; i++)
            {
                var bees = beehives[i];
                
                if (bees>=power)
                {
                    beehives[i] -= power;
                    if (firstHorn<hornets.Count)
                    {
                        power -= hornets[firstHorn];
                        firstHorn++;
                    }
                    
                }
                else
                {
                    beehives[i] -= power;
                }
                if (hornets.Count<=0)
                {
                    break;
                }
            }
            var leftBees = beehives.Where(a => a > 0).ToList();
            if (beehives.Any(a=>a>0))
            {
                Console.WriteLine(string.Join(" ",beehives.Where(a=>a>0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets.Skip(firstHorn)));
            }
        }
    }
}
