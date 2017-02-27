using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var minNUm = int.MaxValue;
            foreach (var num in numbers)
            {
                if (num<minNUm)
                {
                    minNUm = num;
                }
            }
            Console.WriteLine(minNUm);
        }
    }
}
