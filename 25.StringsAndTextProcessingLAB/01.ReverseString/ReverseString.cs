using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine();
            Console.WriteLine(ReversedString(inputLIne)); 
        }

        public static string ReversedString(string input)
        {
            var Arr = input.ToCharArray();
            Array.Reverse(Arr);
            return string.Join("",Arr);
        }
    }
}
