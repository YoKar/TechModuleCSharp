using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            string answer = string.Empty;
            string word = string.Empty;
            for (int i = 0; i < counter; i++)
            {
                 word = Console.ReadLine();
                answer += word+delimeter;
            }
            string removeLastChar = answer.Remove(answer.Length - delimeter.Length,delimeter.Length);
            Console.WriteLine($"{removeLastChar}");
        }
    }
}
