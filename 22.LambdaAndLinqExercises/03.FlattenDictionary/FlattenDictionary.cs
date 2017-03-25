using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> DicString = new Dictionary<string, Dictionary<string, string>>();
           
            var inputLine = Console.ReadLine();
            while (inputLine!= "end")
            {
                var inputParams = inputLine.Split(' ');
                if (inputParams[0] != "flatten")
                {
                    var kay = inputParams[0];
                    var innerKay = inputParams[1];
                    var innerValue = inputParams[2];
                    if (!DicString.ContainsKey(kay))
                        if (!DicString.ContainsKey(kay))
                        {
                            DicString.Add(kay, new Dictionary<string, string>());
                        }
                    DicString[kay][innerKay] = innerValue;
                }  
                
                else
                {
                    var kay = inputParams[1];
                    DicString[kay] = DicString[kay].ToDictionary(x => x.Key + x.Value, x => "flatten");
                }

                inputLine = Console.ReadLine();
            }
            
            Dictionary<string, Dictionary<string, string>> orderDictionary = DicString.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);
            foreach (var entry in orderDictionary)
            {
                var counter = 1;
                Console.WriteLine("{0}",entry.Key);
                Dictionary<string, string> orderInnerkAYS = entry.Value.
                    OrderBy(x => x.Key.Length).Where(x=>x.Value!= "flatten")
                    . ToDictionary(x => x.Key, x => x.Value);
                Dictionary<string, string> flatenValues = entry.Value.Where(x => x.Value == "flatten").ToDictionary(x => x.Key, x => x.Value);
                foreach (var InnerEntry in orderInnerkAYS)
                {
                    Console.WriteLine("{0}. {1} - {2}",counter,InnerEntry.Key,InnerEntry.Value);
                    counter++;
                }
                foreach (var innerflaten in flatenValues)
                {
                    Console.WriteLine("{0}. {1}",counter,innerflaten.Key);
                    counter++;
                }
            }
           
           
        }
    }
}
