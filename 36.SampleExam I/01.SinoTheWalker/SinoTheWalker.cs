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
            var leavingSoftUni = TimeSpan.ParseExact(Console.ReadLine(),timeFormat,CultureInfo.InvariantCulture);
            var steps = decimal.Parse(Console.ReadLine());
            var secondsForStep = decimal.Parse(Console.ReadLine());
            var oneDay = 60 * 60 * 24;
            var stepsSeconds =(int) ((steps * secondsForStep)%oneDay);
            var Arraival = leavingSoftUni.Add(new TimeSpan(0, 0, stepsSeconds));
            Console.WriteLine("Time Arrival: {0}",Arraival.ToString(timeFormat));
        }
    }
}
