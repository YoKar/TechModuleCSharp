using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayElementsEqualToTheirIndex
{
    class ArrayElementsEqualToTheirIndex
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string answer = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==i)
                {
                    answer += i+" ";
               }
            }
            Console.WriteLine(answer);
        }
    }
}
