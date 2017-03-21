using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABDictionaries
{
    class Dictionaries
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var dictionaries = new SortedDictionary<double, int>();
            foreach (var num in numbers)
            {
                if (!dictionaries.ContainsKey(num))
                {
                    dictionaries[num] = 0;
                }
                dictionaries[num]++;
            }
            foreach (var kvp in dictionaries)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
