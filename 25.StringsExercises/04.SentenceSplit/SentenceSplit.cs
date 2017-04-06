using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            var sentence = Console.ReadLine();
            var inoutLIne = Console.ReadLine().Split();
            var listD = new List<string>();
            var CharList = new List<char>();
            
            for (int i = 0; i < inoutLIne.Length; i++)
            {
                if (inoutLIne[i]!=string.Empty)
                {
                    CharList.Add(char.Parse(inoutLIne[i]));
                }
             }
            var delimeter = string.Empty;
            delimeter = string.Join("", CharList);
            //char delimeter = char.Parse(inoutLIne[coutnter]);
            var text = sentence.Split(new[]{ delimeter}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length; i++)
            {
                listD.Add(text[i].Trim());
            }
            Console.WriteLine("[{0}]", string.Join(", ", listD));


        }
    }
}
