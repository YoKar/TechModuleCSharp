using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {

            var deamons = Console.ReadLine().Split(',').Select(a => a.Trim());
            var chars = @"([^\+\-\*\/0-9.])";
            var digits = @"([+-]?(?:[0-9]*[.])?[0-9]+)";
            var multOrNot = @"(\/|\*)";
            Regex Chars = new Regex(chars);
            Regex Dig = new Regex(digits);
            Regex MultOr = new Regex(multOrNot);
          
            foreach (var deamon in deamons.OrderBy(a=>a))
            {
                MatchCollection DeamonChar = Chars.Matches(deamon);
                MatchCollection DeamonDigits = Dig.Matches(deamon);
                MatchCollection DeamonMultiOrNot = MultOr.Matches(deamon);
                var helth = 0;
                var demege = 0.0;
                
                foreach (Match item in DeamonChar)
                {
                    if (item.Value!="_")
                    {
                        var Char = char.Parse(item.Value);
                        helth += Convert.ToInt32(Char);
                    }
                    
                }
                foreach (Match demeg  in DeamonDigits)
                {
                    var Dem = double.Parse(demeg.Value);
                    demege += Dem;
                }
                foreach (Match Multiple in DeamonMultiOrNot)
                {
                    if (Multiple.Value=="*")
                    {
                        demege *= 2;
                    }
                    if (Multiple.Value == "/")
                    {
                        demege /= 2;
                    }
                   
                }
                Console.WriteLine("{0} - {1} health, {2:f2} damage", deamon,helth,demege);
            }
        }
    }
}
