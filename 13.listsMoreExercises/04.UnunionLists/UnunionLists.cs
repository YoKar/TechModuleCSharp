using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            var prime = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var primelList = prime.Distinct().ToList();


            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var list = currentList.Distinct().ToList();
                foreach (var nums in list)
                {
                    if (primelList.Contains(nums))
                    {
                        primelList.Remove(nums);
                    }
                    else
                    {
                        primelList.Add(nums);
                    }
                }
            }
            primelList.Sort();
            Console.WriteLine(string.Join(" ",primelList));
        }
    }
}
