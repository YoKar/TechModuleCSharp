using System;

using System.Linq;


namespace _06.EqualSequenceOfElementsInArray
{
    class EqualSequenceOfElementsInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool IsEqual = true;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]!=numbers[i+1])
                {
                    IsEqual = false;
                }
            }
            if (IsEqual)
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
