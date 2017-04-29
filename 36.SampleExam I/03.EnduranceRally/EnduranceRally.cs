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
            var driversNames = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            var checkpoints = Console.ReadLine().Split().Select(long.Parse).ToList();
            
            foreach (var name in driversNames)
            {
                bool HaveFuekOrNot = true;
                decimal fuel = name[0];
                
                for (int i = 0; i < zones.Count; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += zones[i];
                       
                    }
                    else
                    {
                        fuel -= zones[i];
                    }
                    if (fuel<=0)
                    {
                        Console.WriteLine("{0} - reached {1}",name,i);
                        HaveFuekOrNot = false;
                        break;
                    }
                }
                if ( HaveFuekOrNot )
                {
                    Console.WriteLine("{0} - fuel left {1:f2}",name,fuel);
                }
            }
        }
    }
}
