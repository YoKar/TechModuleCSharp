using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            Regex regex = new Regex(@"(([2-9]|1[0])|([JQKA]))[SHDC]");
            var reslut = regex.Match(inputLine);
            var listResult = new List<string>();
            while (reslut.Success)
            {
                listResult.Add(reslut.Value);
                reslut = reslut.NextMatch();
            }


            Console.WriteLine(string.Join(", ", listResult));
        }
    }
}