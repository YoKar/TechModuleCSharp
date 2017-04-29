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
            var inputLine = Console.ReadLine().Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, Dictionary<int, double>> OrderedDic = new SortedDictionary<string, Dictionary<int, double>>();
            foreach (var demonEntry in inputLine)
            {
                var psevdoHelth = demonEntry.Where(a => !char.IsDigit(a) && a != '+' && a != '-' && a != '*' && a != '/' && a != '.');
                var helth = 0;
                foreach (var item in psevdoHelth)
                {
                    helth += (int)item;
                }
                var demeges = 0.0;
                var pattern = @"-?\d+\.?\d*";
                Regex regex = new Regex(pattern);
                var matches = regex.Matches(demonEntry);
                foreach (Match match in matches)
                {
                    var num = match.Value;
                    demeges += double.Parse(num);
                }
                var MultyOrDevin = demonEntry.Where(a => a == '*' || a == '/');
                foreach (var item in MultyOrDevin)
                {
                    if (item=='*')
                    {
                        demeges *= 2;
                    }
                    else
                    {
                        demeges /= 2;
                    }
                }
                if (!OrderedDic.ContainsKey(demonEntry))
                {
                    OrderedDic[demonEntry] = new Dictionary<int, double>(); 
                }
                OrderedDic[demonEntry].Add(helth, demeges);
            }
            foreach (var demon in OrderedDic)
            {
                Console.Write($"{demon.Key} - ");
                foreach (var valu in demon.Value)
                {
                    Console.WriteLine($"{valu.Key} health, {valu.Value:f2} damage");
                }
            }
        }
    }
}
