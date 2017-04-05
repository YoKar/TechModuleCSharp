using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(" ,?!.".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var words = new List<string>();
            foreach (var word in inputLine)
            {
                var leftPart = word;
                var rightPart =word.ToCharArray();
                Array.Reverse(rightPart);
                if (leftPart == string.Join("",rightPart))
                {
                    words.Add(word);
                }
            }
            words.Sort();
           var uniqueWords = words.Distinct().ToList();
            Console.WriteLine(string.Join(", ",uniqueWords));
        }
    }
}
