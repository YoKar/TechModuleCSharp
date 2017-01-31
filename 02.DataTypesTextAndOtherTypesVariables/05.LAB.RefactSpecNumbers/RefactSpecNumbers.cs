using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LAB.RefactSpecNumbers
{
    class RefactSpecNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;
            int counter = 0;
            bool isNumberTrueOrFalse = true;
            for (int i = 1; i <= number; i++)
            {
                counter = i;
                while (i > 0)
                {
                    sumOfNumbers += i % 10;
                    i = i / 10;
                }
                isNumberTrueOrFalse = (sumOfNumbers == 5) || (sumOfNumbers == 7) || (sumOfNumbers == 11);
                Console.WriteLine($"{counter} -> {isNumberTrueOrFalse}");
                sumOfNumbers = 0;
                i = counter;
               
            }

        }
    }
}
