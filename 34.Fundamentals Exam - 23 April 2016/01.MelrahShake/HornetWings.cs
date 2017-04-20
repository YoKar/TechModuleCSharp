using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MelrahShake
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            var GivenFlaps = decimal.Parse(Console.ReadLine());
            var DistanseForThousFlasps = decimal.Parse(Console.ReadLine());
            var FlapsForBreak = decimal.Parse(Console.ReadLine());
            var realMeters = (GivenFlaps / 1000) * DistanseForThousFlasps;
            int seconds = (int)(GivenFlaps / 100);
            seconds += ((int)(GivenFlaps / FlapsForBreak))*5;
            Console.WriteLine("{0:f2} m.",realMeters);
            Console.WriteLine("{0:f0} s.",seconds);
        }
    }
}
