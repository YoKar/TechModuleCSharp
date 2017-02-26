using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNums = new List<int>();
            numbers.Sort();
            numbers.Reverse();
            foreach (var num in numbers)
            {
                double nums = 0;
                nums = Math.Sqrt(num);
                if (nums==(int)nums)
                {
                    squareNums.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ",squareNums));
        }
    }
}
