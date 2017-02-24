using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var currence = 1;
            numbers.Sort();
            
                for (int i = 0; i < numbers.Count-1 ; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        currence++;
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} -> {currence}");
                        currence = 1;
                    }
                }
                Console.WriteLine($"{numbers[numbers.Count-1]} -> {currence}");
            
            
        }
    }
}
