using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dic_Red
{
    class Program
    {
        static void Main(string[] args)
        {
            var NameAndNumber = Console.ReadLine();
            var resultDic = new Dictionary<string , long>();

            while (NameAndNumber != "end")
            {
                var tokens = NameAndNumber.Split();
                var firstPart = tokens[0];
                var lastPart = tokens[tokens.Length - 1];
                long numLast = 0;
                if (long.TryParse(lastPart, out numLast))
                {
                    resultDic[firstPart] = numLast;
                }
                else
                {
                    if (resultDic.ContainsKey(lastPart))
                    {
                        var referencedValue = resultDic[lastPart];
                        resultDic[firstPart] = referencedValue;
                    }
                    
                }
                NameAndNumber = Console.ReadLine();
            }
            foreach (var ItemPart in resultDic)
            {
                var item = ItemPart.Key;
                var part = ItemPart.Value;
                Console.WriteLine($"{item} === {part}");
            }
        }
    }
}
