using System;

using System.Linq;


namespace _05.IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool IsIncreased = true;
            
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]>numbers[i+1])
                {
                    IsIncreased = false;
                }
            }
            if (IsIncreased)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
