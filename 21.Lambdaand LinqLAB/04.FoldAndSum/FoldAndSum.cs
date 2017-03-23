using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = nums.Length/4;
            var UperPart = nums.Take(k).Reverse().ToArray();
            UperPart = UperPart.Concat(nums.Reverse().Take(k)).ToArray();
             
            var dawnPart = nums.Skip(k).Take(2*k).ToArray();
            var finalSum = new List<int>();
            for (int i = 0; i < dawnPart.Length; i++)
            {
                finalSum.Add(UperPart[i] + dawnPart[i]);
            }
            Console.WriteLine(string.Join(" ",finalSum));
        }
    }
}
