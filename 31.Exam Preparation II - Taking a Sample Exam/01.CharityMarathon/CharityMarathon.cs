using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var Laps = int.Parse(Console.ReadLine());
            var LenghtOfLap = decimal.Parse(Console.ReadLine());
            var CapacityOfRuners = int.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var CapForAllRace = days * CapacityOfRuners;
            if (runners>CapForAllRace)
            {
                runners = CapForAllRace;
            }
            LenghtOfLap /= 1000;
            decimal TotalMeters = runners * Laps * LenghtOfLap;
            decimal Money = TotalMeters * moneyPerKilometer;
            Console.WriteLine("Money raised: {0:f2}",Money);
        }
    }
}
