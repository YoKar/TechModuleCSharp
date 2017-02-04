using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < num; i++)
            {
                int asciiNum = int.Parse(Console.ReadLine());
                word += Convert.ToChar(asciiNum); 
            }
            Console.WriteLine(word);
        }
    }
}
