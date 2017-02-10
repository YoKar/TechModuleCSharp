using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IntegerToBase
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int baseNumber = int.Parse(Console.ReadLine());
            PrintIntegerToBase(number , baseNumber);

        }

        private static void PrintIntegerToBase(long a , int b)
        {
            string result = string.Empty;
            while (a>0)
            {
                
                long temp = a % b;
                result = temp + result;
                a /= b;
            }
            Console.WriteLine(result);
            
        }
    }
}
