using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();
            nums.Reverse();
            foreach (var item in nums)
            {
                List<string> nums2 = item.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums2);
            }
            
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
