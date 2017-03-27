using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LambadaExpressions
{
    class LambadaExpressions
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> slectorDicitionary = new Dictionary<string, Dictionary<string, string>>();
            var inputLine = Console.ReadLine();
            while (inputLine!="lambada")
            {
                var tokens = inputLine.Split("=> .".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var lecetor = tokens[0];
                if (lecetor!="dance")
                {
                    
                    var selectorObject = tokens[1];
                    var propery = tokens[2];
                    if (!slectorDicitionary.ContainsKey(lecetor))
                    {
                        slectorDicitionary[lecetor] = new Dictionary<string, string>();
                    }
                    slectorDicitionary[lecetor][selectorObject] = propery;
                }
                else
                {
                    slectorDicitionary = slectorDicitionary.ToDictionary(x => x.Key, x => x.Value.ToDictionary(y => y.Key, y => y.Key + "." + y.Value));
                }
                inputLine = Console.ReadLine();

            }
            foreach (var item in slectorDicitionary)
            {
                Console.Write("{0} => ",item.Key);
                foreach (var itemPart in item.Value)
                {
                    Console.WriteLine("{0}.{1}",itemPart.Key,itemPart.Value);
                }
            }
        }
    }
}
