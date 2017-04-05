using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var Text = Console.ReadLine().ToLower();
            var inputLIne = Console.ReadLine().ToLower();
            var index = Text.IndexOf(inputLIne);
            var counter = 0;
            while (index!=-1)
            {
                counter++;
                index = Text.IndexOf(inputLIne,index+1);
            }
            Console.WriteLine(counter);
        }
    }
}
