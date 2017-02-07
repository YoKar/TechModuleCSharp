using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
           double result =  PawNumbers(num1 , num2);
            Console.WriteLine(result);
        }

        private static double PawNumbers(double a , int b)
        {
            double result = Math.Pow(a, b);
            return result;
        }
    }
}
