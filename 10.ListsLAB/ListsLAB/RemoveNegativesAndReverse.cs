using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLAB
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            numbers.Reverse();
            foreach (var num in numbers)
            {
                if (num>0)
                {
                    result.Add(num);
                }
            }
            if (result.Count<=0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",result));
            }
        }
    }
}
