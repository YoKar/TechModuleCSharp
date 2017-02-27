using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_sBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var camelBack = int.Parse(Console.ReadLine());
            var nums = new List<int>();
            foreach (var num in numbers)
            {
                nums.Add(num);
            }
            var round = 0;
            for (int i = 0; i < (numbers.Count-camelBack)/2; i++)
            {
                nums.RemoveAt(0);
                nums.RemoveAt(nums.Count - 1);
                round++;
            }
            if (camelBack==numbers.Count)
            {
                Console.WriteLine($"already stable: {string.Join(" ",numbers)}");
            }
            else
            {
                Console.WriteLine($"{round} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", nums)}");
            }
            
        }
    }
}
