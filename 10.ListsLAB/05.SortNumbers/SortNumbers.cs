using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
         
            reversedNUmbers(numbers);
        }

        private static void reversedNUmbers(List<decimal> numbers)
        {
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
