using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CottageScraper
{
    class CottageScraper
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            Dictionary<string, List<int>> InputDic = new Dictionary<string, List<int>>();
            var counter = 0;
            while (inputLine!= "chop chop")
            {
                var tokens = inputLine.Split(" ->".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var type = tokens[0];
                var height = int.Parse(tokens[1]);
                if (!InputDic.ContainsKey(type))
                {
                    InputDic[type] = new List<int>();
                }
                InputDic[type].Add(height);
                inputLine = Console.ReadLine();
                counter++;
            }
            inputLine = Console.ReadLine();
            var num = int.Parse(Console.ReadLine());
            var sumOfAllLogs = 0.0m;
            var UsedLogsPrice = 0.0m;
            var unUsedLogs = 0.0m;
            var CottageScraper = 0.0m;
            foreach (var item in InputDic)
            {
                foreach (var Part in item.Value)
                {
                    sumOfAllLogs += Part;
                    if (item.Key==inputLine&& Part>=num)
                    {
                        UsedLogsPrice += Part;
                    }
                    else if ((item.Key != inputLine && Part <= num||Part>num)|| (item.Key == inputLine && Part <num ))
                    {
                        unUsedLogs += Part;
                    }
                }
            }
            sumOfAllLogs =Math.Round(sumOfAllLogs/ counter,2);
            UsedLogsPrice *=Math.Round( sumOfAllLogs,2);
            unUsedLogs =Math.Round( Math.Round(unUsedLogs * sumOfAllLogs,2) * 0.25m,2);
            CottageScraper = UsedLogsPrice + Math.Round( unUsedLogs,2);
            Console.WriteLine("Price per meter: ${0:f2}",sumOfAllLogs);
            Console.WriteLine("Used logs price: ${0:f2}",UsedLogsPrice);
            Console.WriteLine("Unused logs price: ${0:f2}",unUsedLogs);
            Console.WriteLine("CottageScraper subtotal: ${0:f2}",CottageScraper);
        }
    }
}
