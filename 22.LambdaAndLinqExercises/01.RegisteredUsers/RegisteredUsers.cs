using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var NameDate = new Dictionary<string, DateTime>();
            var inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                var tokens = inputLine.Split(" ->".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                NameDate.Add(name, date);
                inputLine = Console.ReadLine();
            }
            var FinalDi = NameDate.
                Reverse()
                .OrderBy(x => x.Value)
                .ToDictionary(x => x.Key , x=> x.Value)
                .Take(5)
                .OrderByDescending(x=> x.Value)
                ;
            foreach (var item in FinalDi)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
