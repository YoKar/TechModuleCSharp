using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OddNumbersAtOddPositions
{
    class OddNumbersAtOddPositions
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i%2==1&&Math.Abs(numbers[i])%2==1)
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
                }
            }
           
        }
    }
}
