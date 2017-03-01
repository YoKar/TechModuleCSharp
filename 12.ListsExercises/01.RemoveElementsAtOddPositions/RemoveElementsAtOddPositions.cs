using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ListsExercises
{
    class RemoveElementsAtOddPositions
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();
            var countter = 1;
            for (int i = 0; i < words.Count; i++)
            {
                
                if (countter%2!=0)
                {
                    words.RemoveAt(i);
                }
                else
                {
                    i--;
                }
                countter++;
                
            }
            Console.WriteLine(string.Join("",words));
        }
    }
}
