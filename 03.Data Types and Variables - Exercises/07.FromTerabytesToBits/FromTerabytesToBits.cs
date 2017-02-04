using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        {
            float terabytes = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:f0}",((decimal)(terabytes)* 1024 * 1024 * 1024 * 1024 * 8));
        }
    }
}
