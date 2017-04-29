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
            var Days = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var laps = int.Parse(Console.ReadLine());
            var Distance = long.Parse(Console.ReadLine());
            var capacityOfRuners = int.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

           decimal TheRunners = 0;
            if (capacityOfRuners*Days<runners)
            {
                TheRunners = capacityOfRuners * Days;
            }
            else
            {
                TheRunners = runners;
            }
            decimal TotalKilometers = (TheRunners * laps * Distance)/1000;
            var totalMoney = TotalKilometers * moneyPerKilometer;
            Console.WriteLine("Money raised: {0:f2}",totalMoney);
        }
    }
}
