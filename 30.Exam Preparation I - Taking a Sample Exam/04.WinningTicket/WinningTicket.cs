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
            var pattern = @"([@#$^])\1{5,}";
            Regex regex = new Regex(pattern);
            var inputLine = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();

            foreach (var item in inputLine)
            {
                var leftHalf = item.Substring(item.Length / 2);
                var rightHalf = item.Remove(item.Length - item.Length / 2);
                Match firstMatch = regex.Match(leftHalf);
                Match secondMatch = regex.Match(rightHalf);
                if (item.Length < 20||item.Length>20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (firstMatch.Success&&secondMatch.Success)
                {
                    var ShortestMatch = Math.Min(firstMatch.Length, secondMatch.Length);
                    
                    if (ShortestMatch==10)
                    {
                        Console.WriteLine("ticket \"{0}\" - 10{1} Jackpot!",item, firstMatch.Value.Substring(firstMatch.Length - 1));
                    }
                    else 
                    {
                        Console.WriteLine("ticket \"{0}\" - {1}{2}", item, ShortestMatch, firstMatch.Value.Substring(firstMatch.Length - 1));
                    }
                }
                else  
                {
                    Console.WriteLine("ticket \"{0}\" - no match",item);
                }
                
            }
        }
    }
}
