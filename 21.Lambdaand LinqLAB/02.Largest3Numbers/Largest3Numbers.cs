using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
