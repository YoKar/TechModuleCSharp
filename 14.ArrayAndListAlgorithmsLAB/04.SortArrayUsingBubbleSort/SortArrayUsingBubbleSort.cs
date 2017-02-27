using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

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
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
