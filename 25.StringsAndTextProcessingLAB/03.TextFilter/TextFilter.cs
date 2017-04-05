using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var BannedWords = Console.ReadLine().Split(" ,".ToArray(),StringSplitOptions.RemoveEmptyEntries);
            var Text = Console.ReadLine();
           
            foreach (var word in BannedWords)
            {
                if (Text.Contains(word))
                {
                    Text = Text.Replace(word, new string('*', word.Length));
                }
                
            }
            Console.WriteLine(Text);
        }
    }
}
