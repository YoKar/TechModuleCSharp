using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().ToUpper();
            var Hash = new HashSet<string>();
            var ListOfUniq = new List<string>();
            var patern = @"(.+?)([0-9]+)";
            Regex regex = new Regex(patern);
            var pattersnChar = @".";
            Regex SingleChar = new Regex(pattersnChar);
            MatchCollection matches = regex.Matches(inputLine);
            foreach (Match item in matches)
            {

                MatchCollection charMatches = SingleChar.Matches(item.Groups[1].Value);
                if (int.Parse(item.Groups[2].Value) != 0)
                {
                    foreach (Match items in charMatches)
                    {

                        Hash.Add(items.Value);

                    }

                }


                var str = string.Empty;
                var counter = int.Parse(item.Groups[2].Value);
                for (int i = 0; i < counter; i++)
                {
                    str += item.Groups[1].Value;
                }
                ListOfUniq.Add(str);
            }
            // Hash.Remove(" ");
            Console.WriteLine("Unique symbols used: {0}", Hash.Count);
            Console.WriteLine(string.Join("", ListOfUniq));
        }
    }
}
