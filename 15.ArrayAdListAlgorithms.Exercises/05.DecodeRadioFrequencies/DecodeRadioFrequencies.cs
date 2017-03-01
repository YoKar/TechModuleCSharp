using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            var Numbers = Console.ReadLine().Split(' ', '.').Select(int.Parse).ToArray();
            var LeftstringLst = new List<char>();
            var RightStringleters = new List<char>();
            var firstCounter = 0;
            
            for (int i = 0; i < Numbers.Length-1; i++)
            {
                  char firstLeter = Convert.ToChar(Numbers[i]);
                if (firstLeter!='\0')
                {
                    LeftstringLst.Add(firstLeter);
                }
                char lastLiter = Convert.ToChar(Numbers[i + 1]);
                if (lastLiter!='\0')
                {
                    RightStringleters.Insert(firstCounter, lastLiter);
                }
                    i++;
             }
            var finalLIst = new List<char>();
            foreach (var leter in LeftstringLst)
            {
                finalLIst.Add(leter);
            }
           
            foreach (var leter in RightStringleters)
            {
               
                finalLIst.Add(leter);
            }
           
            Console.WriteLine(string.Join("",finalLIst));
        }
    }
}
