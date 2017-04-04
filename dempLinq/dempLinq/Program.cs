using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dempLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var NameAndData = Console.ReadLine();
            var Names = new Dictionary<string, DateTime>();
            while (NameAndData!="end")
            {
                var tokens = NameAndData.Split(" ->".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                DateTime data = DateTime.ParseExact(tokens[1], "d/M/yyyy", CultureInfo.InvariantCulture);
                Names.Add(name, data);
                NameAndData = Console.ReadLine();
            }
            var newDic = Names.Reverse().OrderBy(x=>x.Value).Take(5).OrderByDescending(x=>x.Value);
            foreach (var item in newDic)
            {
                Console.WriteLine(item.Key);
            }


        }
    }
}
