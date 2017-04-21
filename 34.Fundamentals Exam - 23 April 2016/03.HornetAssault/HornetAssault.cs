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
            var BeeHive = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var HornetsPower = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var counter = BeeHive.Count;

            long SumOfHornetPwoer = HornetsPower.Sum();
            for (int i = 0; i < BeeHive.Count; i++)
            {
                if (HornetsPower.Count <= 0)
                {
                    break;
                }
                if (SumOfHornetPwoer <= BeeHive[i])
                {
                    BeeHive[i] -= HornetsPower.Sum();
                    HornetsPower.RemoveAt(0);
                }
                else
                {
                    BeeHive[i] = 0;
                }
                SumOfHornetPwoer = HornetsPower.Sum();
            }

            var NoneZero = BeeHive.Where(e => e != 0).ToList();
            //for (int i = 0; i < BeeHive.Count; i++)
            //{
            //    if (BeeHive[i] <= 0)
            //    {
            //        BeeHive.Remove(i);
            //        i--;
            //    }
            //}
            if (NoneZero.Count > 0)
            {

                Console.WriteLine(string.Join(" ", NoneZero));
            }
            else
            {
                Console.WriteLine(string.Join(" ", HornetsPower));
            }
        }
    }
}
