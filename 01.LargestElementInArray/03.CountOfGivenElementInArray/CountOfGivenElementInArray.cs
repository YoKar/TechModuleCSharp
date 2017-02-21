using System;

using System.Linq;


namespace _03.CountOfGivenElementInArray
{
    class CountOfGivenElementInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int countter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==n)
                {
                    countter++;
                }
            }
            Console.WriteLine(countter);
        }
    }
}
