using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                var tokens = inputLine.Split("->".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var text = tokens[0].Trim();
                var placehoders = tokens[1].Trim().Split(" ,".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < placehoders.Length; i++)
                {
                    var currentPLaceholders = "{" + i + "}";
                   text= text.Replace(currentPLaceholders, placehoders[i]);
                }
                Console.WriteLine(text);
                inputLine = Console.ReadLine();
            }
        }
    }
}
