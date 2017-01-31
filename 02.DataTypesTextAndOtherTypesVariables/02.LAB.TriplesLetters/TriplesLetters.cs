using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LAB.TriplesLetters
{
    class TriplesLetters
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number;j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        Console.WriteLine("{0}{1}{2}",(char)(i+97),(char)(j+97),(char)(k+97));
                    }
                }
            }
        }
    }
}
