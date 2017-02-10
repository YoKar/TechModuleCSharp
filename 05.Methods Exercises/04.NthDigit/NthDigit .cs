using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
           long result = FindNthDigit(number , index);
            Console.WriteLine(result);
        }

        private static long FindNthDigit(long a , int b)
        {
            int counter = 1;
            long number2 = 0;
            long index2 = 0;
            long index3 = a;
            while (a>0)
            {
                
               index2 = index3 % 10;
               
                if (counter==b)
                {
                    number2 = index2;
                    break;
                }
                index3 /=   10;
                counter++;
            }
            return number2;
        }
    }
}
