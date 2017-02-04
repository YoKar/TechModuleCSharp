using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            byte a = 0;
            int times = 0;
            for (int i = 0; i < num; i++)
            {
                a++;
                if (a==0)
                {
                    times++;
                }
            }
            Console.WriteLine(a);
            Console.WriteLine("Overflowed {0} times",times);
        }
    }
}
