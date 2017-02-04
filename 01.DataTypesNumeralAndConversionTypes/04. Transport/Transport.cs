using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int persones = int.Parse(Console.ReadLine());
            double carCapacity = 4 + 8 + 12;
            Console.WriteLine("{0}", Math.Ceiling(persones / carCapacity));
        }
    }
}
