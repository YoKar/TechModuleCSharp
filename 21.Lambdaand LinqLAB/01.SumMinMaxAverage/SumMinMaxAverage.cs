using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumMinMaxAverage
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            Console.WriteLine("Sum = {0}",numbers.Sum());
            Console.WriteLine("Min = {0}",numbers.Min());
            Console.WriteLine("Max = {0}",numbers.Max());
            Console.WriteLine("Average = {0}",numbers.Average());
        }
    }
}
