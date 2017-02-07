using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(1,number);
        }

        static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int k = start; k <= i; k++)
                {
                    Console.Write(k + new string(' ',1));
                }
                Console.WriteLine();
            }
            for (int j = end-1; j >= start; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
