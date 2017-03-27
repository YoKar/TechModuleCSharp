using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var dateString = Console.ReadLine();
            var date = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
