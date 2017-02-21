using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            bool isTrue = true;
            for (int i = 0; i < words.Length / 2; i++)
            {
                string firstWord = words[i];
                string secondWord = words[words.Length - 1 - i];
                if (firstWord!=secondWord)
                {
                    isTrue = false;
                }

            }
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
