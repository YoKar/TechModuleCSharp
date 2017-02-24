using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasin
{
    class Program
    {
        private static bool lowerLeters;

        static void Main(string[] args)
        {
            char[] separator = new char[] { ',',';',':','.','!','(',')', '\"','\\','/','[',']', ' ' ,'\''};
            var words = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lowerWords = new List<string>();
            var uperWords = new List<string>();
            var mixedWords = new List<string>();
            foreach (var word in words)
            {
                var lowereLeters = 0;
                var UpperLeters = 0;
                var mixedLeters = 0;
                foreach (var leter in word)
                {
                    if ((char)leter>=65&&(char)leter<=90)
                    {
                        UpperLeters++;
                    }
                    else if ((char)leter>=97&&(char)leter<=122)
                    {
                        lowereLeters++;
                    }
                    else
                    {
                        mixedLeters++;
                    }
                }
                if (UpperLeters==word.Length)
                {
                    uperWords.Add(word);
                    UpperLeters = 0;
                }
                else if(lowereLeters==word.Length)
                {
                    lowerWords.Add(word);
                    lowereLeters = 0;
                }
                else 
                {
                    mixedWords.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}",string.Join(", ",lowerWords));
            Console.WriteLine("Mixed-case: {0}",string.Join(", ",mixedWords));
            Console.WriteLine("Upper-case: {0}",string.Join(", ",uperWords));

        }
    }
}
