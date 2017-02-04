using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.InHexadecimalFormat
{
    class VariableIHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexNum, 16));
        }
    }
}
