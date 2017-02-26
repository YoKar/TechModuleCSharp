using System;

using System.Linq;


namespace _04.CountOccurrencesOfLargerNumbersInArray
{
    class CountOccurrencesOfLargerNumbersInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int countter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>p)
                {
                    countter++;
                }
            }
            Console.WriteLine(countter);
        }
    }
}
