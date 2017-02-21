﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i])%2==1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
