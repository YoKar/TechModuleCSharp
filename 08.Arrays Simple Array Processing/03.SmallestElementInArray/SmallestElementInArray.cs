using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var minNumber = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<minNumber)
                {
                    minNumber = arr[i];
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
