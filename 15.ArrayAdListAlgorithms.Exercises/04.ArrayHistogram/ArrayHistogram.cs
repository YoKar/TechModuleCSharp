using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            var leters = new List<string>();
            var counter = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (leters.Contains(currentWord))
                {
                    int indexNUm = leters.IndexOf(currentWord);
                    counter[indexNUm]++;
                    continue;
                }
                else
                {
                    leters.Add(words[i]);
                    counter.Add(1);
                }
            }
            bool ISTrueoFalse = true;
            while (ISTrueoFalse)
            {
                ISTrueoFalse = false;
                for (int i = 0; i < leters.Count-1; i++)
                {
                    
                    if (counter[i]<counter[i+1])
                    {
                        var temp = leters[i];
                        leters[i] = leters[i + 1];
                        leters[i + 1] = temp;

                        var temp2 = counter[i];
                        counter[i] = counter[i + 1];
                        counter[i+1]=temp2;
                        ISTrueoFalse = true;
                    }
                }
            }
            for (int i = 0; i < leters.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:f2}%)",leters[i],counter[i],((counter[i]*100.0)/words.Length));
            }
        }
    }
}
