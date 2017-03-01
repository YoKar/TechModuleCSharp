using System;

using System.Linq;


namespace _09.SimpleArrayProcessingExercises
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrOfnumbers = new int[n];
            int maxNUm = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                arrOfnumbers[i] = int.Parse(Console.ReadLine());
                if (arrOfnumbers[i]>maxNUm)
                {
                    maxNUm = arrOfnumbers[i];
                }
            }
            Console.WriteLine(maxNUm);
        }
    }
}
