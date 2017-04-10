using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            while (true)
            {
                if (inputLine == "end")
                {
                    break;
                }
                else
                {
                    string result = Regex.Replace(inputLine, @"<a.*?href.*?=(.*?)>(.*?)<\/a>", @"[URL href=$1]$2[/URL]");

                    Console.WriteLine(result);

                    inputLine = Console.ReadLine();
                }

            }
        }
    }
}
