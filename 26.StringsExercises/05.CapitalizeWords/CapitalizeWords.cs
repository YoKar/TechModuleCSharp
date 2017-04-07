using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine().ToLower();
            var CapitalWords = new List<string>();
           
            while (inputLIne!="end")
            {
                var singleWord = new List<string>();

                var tokens = inputLIne.Split(new[]  { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' } ,StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in tokens)
                {
                    string Cap = string.Empty;
                    foreach (var leters in word)
                    {
                        if (leters==word[0])
                        {
                            var FirstLeter = word[0];
                            var num = (int)FirstLeter - 32;
                            var cap = (char)num;
                            Cap += cap;
                        }
                        else
                        {
                            Cap += leters;
                        }
                        
                    }

                    singleWord.Add(Cap.Trim());
                }
                CapitalWords.Add(string.Join(", ",singleWord));
                inputLIne = Console.ReadLine().ToLower();
               
            }
            Console.WriteLine(string.Join("\n",CapitalWords));
        }
    }
}
