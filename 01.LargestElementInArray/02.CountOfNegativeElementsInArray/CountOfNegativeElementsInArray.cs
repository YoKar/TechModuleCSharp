using System;

using System.Linq;


namespace _02.CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Numbers = new int[n];
            int countter = 0;
            for (int i = 0; i < n; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
                if (Numbers[i]<0)
                {
                    countter++;
                }
            }
            Console.WriteLine(countter);
        }
    }
}
