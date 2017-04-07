using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pyramidic
{
    class Pyramidic
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var listString = new List<string>();
            for (int i = 0; i < N; i++)
            {
                var inputLine = Console.ReadLine();
                listString.Add(inputLine);
            }

            var ch = new char();
            var p = new char();
            var maxDup = 0;
            foreach (var wl in listString)
            {
                var duplicatetChars = wl.GroupBy(s => s).SelectMany(grp => grp.Skip(1)).ToArray();
                if (maxDup<duplicatetChars.Length)
                {
                    ch =duplicatetChars[0];
                }
                if (duplicatetChars.Length>0&&p==ch)
                {
                    p = duplicatetChars[0];
                }
                
            }
          

            string TheChar = ch.ToString();



            var finalList = new List<string>();
            var Sub = TheChar;
            foreach (var leters in listString)
            {
                var counters = TheChar;
                if (leters.Contains(Sub))
                {
                    finalList.Add(Sub);
                    Sub += counters + counters;
                }
            }
            Console.WriteLine(string.Join("\n", finalList));
        }
    }
}
