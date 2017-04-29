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
            var inputLine = Console.ReadLine().Split(',').Select(a=>a.Trim()).ToList();
            var pattern = @"(?<leftSide>[#$@^]{5,}).*(?<rightSide>[#$@^]{5,})";
            Regex regex = new Regex(pattern);
            foreach (var item in inputLine)
            {
                if (item.Length<20||item.Length>20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                Match Match = regex.Match(item);
                if (Match.Success)
                {
                    var leftSide = Match.Groups["leftSide"].Value;
                    var rightSide = Match.Groups["rightSide"].Value;
                   
                    if ((leftSide.Length>=10||rightSide.Length>=10)&&leftSide.Length+rightSide.Length==20)
                    {
                        Console.WriteLine("ticket \"{0}\" - 10{2} Jackpot!", item, leftSide.Length, leftSide[0].ToString());
                    }
                    else
                    {
                        if (leftSide.Length >= rightSide.Length)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", item, leftSide.Length, leftSide[0].ToString());
                        }
                        else if (rightSide.Length >= leftSide.Length)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", item, rightSide.Length, rightSide[0].ToString());
                        }
                      
                        
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
