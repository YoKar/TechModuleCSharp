using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
            var DICwords = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!DICwords.ContainsKey(word))
                {
                    DICwords[word] = 0;
                }
                DICwords[word]++;
            }
            var OddNumWord = new List<string>();
            foreach (var kvp in DICwords)
            {
                if (kvp.Value%2!=0)
                {
                    OddNumWord.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ",OddNumWord));
        }
    }
}
