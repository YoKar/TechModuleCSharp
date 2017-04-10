using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.MatchFullName
{
    public class MatchFullName
    {
       public static void Main(string[] args)
        {
            var InputText = Console.ReadLine();
            var pattern = @"[A-Z][a-z]+\s[A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            var isMacht = regex.IsMatch(InputText);
            Console.WriteLine(isMacht);
        }
    }
}
