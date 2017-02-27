using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var firstDigit = line[0];
                  list.Insert(int.Parse(firstDigit.ToString()), int.Parse(line));

                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));

        }
       
        
    }
}
