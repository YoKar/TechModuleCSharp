using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTesdt
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            Dictionary<string, Dictionary<string, string>> InputDictionary = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> FlattenDicitionary = new Dictionary<string, string>();
            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(' ');
                if (inputParams[0] != "flatten")
                {
                    var kay = inputParams[0];
                    var innerKay = inputParams[1];
                    var innerValue = inputParams[2];
                    if (!InputDictionary.ContainsKey(kay))
                    {
                        InputDictionary[kay] = new Dictionary<string, string>();
                    }
                    InputDictionary[kay][innerKay] = innerValue;

                }
                else
                {
                    var kay = inputParams[1];
                    if (InputDictionary.ContainsKey(kay))
                    {
                        foreach (var item in InputDictionary[kay])
                        {
                            
                                FlattenDicitionary.Add(item.Key, item.Value);
                            
                        }
                        var newDict = InputDictionary
                            .Where(kvp => kay.Contains(kvp.Key))
                             .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                    }
                }
                    inputLine = Console.ReadLine();
            }
            var FlatenList = new List<string>();
            foreach (var item in FlattenDicitionary)
            {
                FlatenList.Add(item.Key + item.Value);
            }
            Dictionary<string, Dictionary<string, string>> OrderedDicitionary = InputDictionary.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);
            var counter = 1;
            foreach (var Kvap in OrderedDicitionary)
            {
                Console.WriteLine(Kvap.Key);
                foreach (var ParItem in Kvap.Value)
                {
                    Console.WriteLine("{0}. {1} - {2}",counter,ParItem.Key,ParItem.Value);
                    counter++;
                }
            }
            foreach (var item in FlatenList)
            {
                Console.WriteLine("{0}. {1}",counter,item);
                counter++;
            }
            
        }
    }
}
