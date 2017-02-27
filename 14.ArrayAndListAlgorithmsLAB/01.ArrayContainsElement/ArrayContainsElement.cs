using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArrayAndListAlgorithmsLAB
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            bool condition = false;
            foreach (var nums in numbers)
            {
                if (nums==num)
                {
                    condition = true;
                    Console.WriteLine("yes");
                    break;
                }
            }
            if (!condition)
            {
                Console.WriteLine("no");
            }
        }
    }
}
