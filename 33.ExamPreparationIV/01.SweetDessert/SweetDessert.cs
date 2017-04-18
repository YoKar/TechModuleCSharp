using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            var Money = decimal.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var BanaPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var PortionsNeeded = numberOfGuests / 6;
            if (numberOfGuests%6>0)
            {
                PortionsNeeded += 1;
            }
            var bananaNeeded = PortionsNeeded * 2;
            var eggsNeeded = PortionsNeeded * 4;
            decimal berriesNeeded = PortionsNeeded * 0.2m;
            decimal moneyNeeded = (bananaNeeded * BanaPrice) + (eggsNeeded * eggsPrice) + (berriesNeeded * berriesPrice);
            if (Money>=moneyNeeded)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",moneyNeeded);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",moneyNeeded-Money);
            }
        }
    }
}
