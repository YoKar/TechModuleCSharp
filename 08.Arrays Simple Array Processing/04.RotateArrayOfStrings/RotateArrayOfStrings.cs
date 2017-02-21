using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string lastChar = arr.Last();
            var word =new string[arr.Length];
            for (int i = 0; i < arr.Length-1; i++)
            {
                word[i]= arr[i];
            }
            var result = string.Join(" ", word);
            Console.WriteLine($"{lastChar} {result}");
        }
    }
}
