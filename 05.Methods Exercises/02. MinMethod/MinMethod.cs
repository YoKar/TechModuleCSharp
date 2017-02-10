using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result =PrintMinNUmber(num1 , num2 , num3);
            Console.WriteLine(result);
        }

        private static int PrintMinNUmber(int a , int b , int c)
        {
            int result = 0;
            if (a<b&&a<c)
            {
                result = a;
            }
            else if(b<a&&b<c)
            {
                result = b;
            }
            else if (c<a&&c<b)
            {
                result = c;
            }
            return result;
        }
    }
}
