using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();
            var pattern = @"[@#$]{6,}(?:\w*|\d*)[@#$]{6,}";
            var numOfPattern = @"([@#$]{6,})";
            Regex regex = new Regex(pattern);
            Regex numPat = new Regex(numOfPattern);
            for (int i = 0; i < inputLine.Length; i++)
            {
                Match ticketsMatch = regex.Match(inputLine[i]);
                
                if (inputLine[i].Length<20)
                {
                    Console.WriteLine("invalid ticket");
                }
               else if (ticketsMatch!=Match.Empty)
                {
                    Match num = numPat.Match(inputLine[i]);
                    if (num.Groups[1].Length>6&& num.Groups[1].Length < 9)
                    {
                        Console.WriteLine("ticket \"{0}\" - {1}{2}", inputLine[i], num.Groups[1].Length,num.Value.Remove(num.Groups[1].Length-1));
                    }
                    else if (num.Groups[1].Length >10)
                    {
                        Console.WriteLine("ticket \"{0}\" - {1}{2} Jackpot!", inputLine[i], num.Groups[1].Length, num.Value.Remove(num.Groups[1].Length - 1));
                    }
                   
                }
            }
        }
    }
}
