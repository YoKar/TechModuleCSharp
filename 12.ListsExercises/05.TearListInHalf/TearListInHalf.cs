using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var leftLIst = new List<int>();
            var rightLIst = new List<int>();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                leftLIst.Add(numbers[i]);
            }
            for (int i =numbers.Count/2; i < numbers.Count; i++)
            {
                rightLIst.Add(numbers[i]);
            }
            var list = string.Join("", rightLIst);
            var rightSplitedlLIst = new List<int>();
             foreach (var num in list)
            {
                rightSplitedlLIst.Add(num-'0');
            }
            var medleCounter = 0;
            var splitedConter = 0;
            var finalList = new List<int>();
            while (splitedConter!=rightSplitedlLIst.Count)
            {
                finalList.Add(rightSplitedlLIst[splitedConter]);
                splitedConter++;
                finalList.Add(leftLIst[medleCounter]);
                medleCounter++;
                finalList.Add(rightSplitedlLIst[splitedConter]);
                splitedConter++;
            }
            Console.WriteLine(string.Join(" ",finalList));
        }
    }
}
