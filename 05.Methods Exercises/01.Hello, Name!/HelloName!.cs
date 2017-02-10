using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreating(name);
            
        }

        private static void PrintGreating(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
