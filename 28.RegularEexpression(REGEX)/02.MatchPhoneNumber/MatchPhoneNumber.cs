using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
   public class MatchPhoneNumber
    {
        public static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine();
            Regex regex = new Regex(@"\+359( |-)\d{1}\1\d{3}\1\d{4}");
            var match = regex.Match(inputLIne);
            Console.WriteLine(match.Value);
        }
    }
}
