using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerssisesDictionaries
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            var leters = Console.ReadLine();
            var dictionary =new Dictionary<char, int>();

            foreach (var leter in leters)
            {
                if (!dictionary.ContainsKey(leter))
                {
                    dictionary[leter] = 0;
                   
                }
                dictionary[leter]++;
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
