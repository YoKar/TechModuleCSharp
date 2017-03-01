using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            var Arrey = Console.ReadLine().Split(' ').ToArray();
            string CHARS = string.Join("",Arrey);
            var SumList = new List<int>();
            var sum = 0;
            var counter = 0;
            foreach (var leter in CHARS)
            {

                SumList.Add((int)leter);
                counter++;
            }
            foreach (var num in SumList)
            {
                sum += num;
            }
            char delimeter = (char)(sum / counter);
            delimeter = char.ToUpper(delimeter);
            string D = Convert.ToString(delimeter);
            Console.WriteLine(string.Join(D,Arrey));
        }
    }
}
