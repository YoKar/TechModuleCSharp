using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            var timeFormat = @"hh\:mm\:ss";
            var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);
            var stepsNeeded = decimal.Parse(Console.ReadLine());
            var secondsPerStep = decimal.Parse(Console.ReadLine());
            var secindsInDay = 60 * 60 * 24;
            var TotalSecondsNeeded = (int) ((stepsNeeded * secondsPerStep)%secindsInDay);
            var ArrivalTime = leavingTime.Add(new TimeSpan(0, 0, TotalSecondsNeeded));
            Console.WriteLine("Time Arrival: "+ArrivalTime.ToString(timeFormat));
        }
    }
}
