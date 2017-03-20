using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var curectPhone = new SortedDictionary<string, long>();
            var mixedPhone = Console.ReadLine();
            while (mixedPhone!="Over")
            {
                var tokens = mixedPhone.Split(" :".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var firstElement = tokens[0];
                var secondElements = tokens[1];
                long number = 0;
                if (long.TryParse(secondElements,out number))
                {
                    curectPhone[firstElement] = number;
                }
                else if(long.TryParse(firstElement, out number))
                {
                    var FirstPart = secondElements;
                    curectPhone[FirstPart] = number;
                }
                mixedPhone = Console.ReadLine();
            }
          
            foreach (var ItemPart in curectPhone)
            {
               
                var Item = ItemPart.Key;
                var Part = ItemPart.Value;
                Console.WriteLine($"{Item} -> {Part}");

            }
        }
    }
}
