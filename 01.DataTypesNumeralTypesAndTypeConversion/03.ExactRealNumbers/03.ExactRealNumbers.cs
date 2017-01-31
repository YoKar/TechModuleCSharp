using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            decimal num2 = 1;
            for (int i = 0; i < counter; i++)
            {

                decimal num = decimal.Parse(Console.ReadLine());
                num2 *= num;
            }
            Console.WriteLine(num2);
        }
    }
}
