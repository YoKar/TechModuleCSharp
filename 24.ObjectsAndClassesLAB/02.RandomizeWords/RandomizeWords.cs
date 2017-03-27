using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var randomWords = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                var second = randomWords.Next(words.Length);
                var old = words[i];
                words[i] = words[second];
                words[second] = old;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
