using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(". , : ; ( ) [ ] \" ' \\ / ! ? ".ToArray(),StringSplitOptions.RemoveEmptyEntries).Where(w=>w.Length<5).OrderBy(x=>x).Distinct().ToList();
            Console.WriteLine(string.Join(", ",words));
        }
    }
}
