using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.listsMoreExercises
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nums = numbers.Distinct().ToList();
            Console.WriteLine(string.Join(" ",nums));
           
            
        }
    }
}
