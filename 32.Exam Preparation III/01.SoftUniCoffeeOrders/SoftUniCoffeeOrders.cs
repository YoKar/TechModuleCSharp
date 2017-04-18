using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            decimal OrderPrice = 0.0m;
           
            for (int i = 0; i < N; i++)
            {
                decimal PricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime Date =DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",CultureInfo.InvariantCulture);
                var capsuleCount = long.Parse(Console.ReadLine());
                decimal days = DateTime.DaysInMonth(Date.Year, Date.Month);
                var oreder = (days * capsuleCount) * PricePerCapsule;
                OrderPrice += oreder;
                Console.WriteLine("The price for the coffee is: ${0:f2}",oreder);
                
            }
            
            Console.WriteLine("Total: ${0:f2}",OrderPrice);

        }
    }
}
