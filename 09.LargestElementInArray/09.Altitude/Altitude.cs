using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            var arrAtitude = Console.ReadLine().Split(' ').ToArray();
            double currentAltitude = double.Parse(arrAtitude[0]);
            for (int i = 1,j=2; i < arrAtitude.Length; i++,j++)
            {
                if (arrAtitude[i].Contains("up"))
                {
                    currentAltitude += double.Parse(arrAtitude[j]);
                }
                else if (arrAtitude[i].Contains("down"))
                {
                    currentAltitude -= double.Parse(arrAtitude[j]);
                    if (currentAltitude<=0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
                
            }
            if (currentAltitude>0)
            {
                Console.WriteLine($"got through safely. current altitude: {currentAltitude}m");
            }
        }
    }
}
