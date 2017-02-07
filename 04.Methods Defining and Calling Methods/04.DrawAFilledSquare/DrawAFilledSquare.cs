using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeadrRow(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintBody(n);
            }
           PrintHeadrRow(n);
        }

        private static void PrintBody(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void PrintHeadrRow(int n)
        {
            Console.WriteLine("{0}",new string ('-',n * 2));
        }
    }
}
