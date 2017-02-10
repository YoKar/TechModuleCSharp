using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            
            string result = PrintWord(counter , word);
        }

        private static string PrintWord(int a , string b)
        {
            string result = string.Empty;
            for (int i = 0; i < a; i++)
            {
                Console.Write(result+b);
            }
            Console.WriteLine();
            return result;
        }
    }
}
