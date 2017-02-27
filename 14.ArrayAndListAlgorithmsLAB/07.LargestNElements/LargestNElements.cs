using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestNElements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());
           
            bool swaped = false;
            do
            {
                swaped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        var temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;

                        swaped = true;
                    }

                }
            } while (swaped);
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var leftIndex = numbers[i];
                var rightIndex = numbers.Length - 1 - i;
                numbers[i] = numbers[rightIndex];
                numbers[rightIndex] = leftIndex;
            }
            Console.WriteLine(string.Join(" ", numbers.Take(number)));
        }
    }
}
