using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReverseArrayInPlace
{
    class ReverseArrayInPlace
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length/2; i++)
            {
                var leftIndex = numbers[i];
                var rightIndex = numbers.Length - 1 - i;
                numbers[i] = numbers[rightIndex];
                numbers[rightIndex] = leftIndex;
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
