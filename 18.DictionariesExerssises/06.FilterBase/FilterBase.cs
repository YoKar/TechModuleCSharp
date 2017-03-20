using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            var NameAndSomething = Console.ReadLine();
            var NAgeSorted = new Dictionary<string, int>();
            var NPositionSorted = new Dictionary<string, string>();
            var NSelarySorted = new Dictionary<string, double>();

            while (NameAndSomething!= "filter base")
            {
                var tokens = NameAndSomething.Split(" ->".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var other = tokens[1];
                var selary = 0.0;
                var ages = 0;
                if (int.TryParse(other,out ages))
                {
                    NAgeSorted[name] = ages;
                }
               else if (double.TryParse(other,out selary))
                {
                    NSelarySorted[name] = selary;
                }
                else 
                {
                    NPositionSorted[name] = other;
                }
                NameAndSomething = Console.ReadLine();
            }
            var finalString = Console.ReadLine();
            if (finalString== "Age")
            {
                foreach (var item in NAgeSorted)
                {
                    Console.WriteLine("Name: {0}",item.Key);
                    Console.WriteLine("Age: {0}",item.Value);
                    Console.WriteLine("====================");
                }
            }
            else if (finalString=="Salary")
            {
                foreach (var item in NSelarySorted)
                {
                    Console.WriteLine("Name: {0}", item.Key);
                    Console.WriteLine("Salary: {0:f2}", item.Value);
                    Console.WriteLine("====================");
                }
            }
            else if (finalString== "Position")
            {
                foreach (var item in NPositionSorted)
                {
                    Console.WriteLine("Name: {0}", item.Key);
                    Console.WriteLine("Position: {0}", item.Value);
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
