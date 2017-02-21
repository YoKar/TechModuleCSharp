using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumArrayElements
{
    class SumArrayElements
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var numbers = new int[num];
           
            for (int i = 0; i < numbers.Length; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
