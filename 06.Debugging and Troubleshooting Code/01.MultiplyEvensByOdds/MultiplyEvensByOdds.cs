using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_and_Troubleshooting_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(Math.Abs(number)));
        }

        private static int GetMultipleOfEvensAndOdds(int a)
        {
            int result = SumOfEvensDigits(a) * SumOfOddsDigits(a);
            return result;
        }

        private static int SumOfOddsDigits(int num1)
        {
            int temp1 = 0;
            int temp2 = 0;
            while (num1 > 0)
            {
                temp1 = num1 % 10;
                if (temp1 % 2 != 0)
                {
                    temp2 += temp1;
                }
                num1 /= 10;
            }
            return temp2;
        }

        private static int SumOfEvensDigits(int num1)
        {
            int temp = 0;
            int temp2 = 0;
            while (num1 > 0)
            {
                temp = num1 % 10;
                if (temp % 2 == 0)
                {
                    temp2 += temp;
                }
                num1 /= 10;
            }
            return temp2;
        }
    }
}
