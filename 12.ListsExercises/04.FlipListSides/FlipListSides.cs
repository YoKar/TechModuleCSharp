using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            var num = new List<string>();

            if (numbers.Count%2==0)
            {
                num.Add(numbers[numbers.Count - 1]);
                for (int i = 1; i < numbers.Count-1; i++)
                {

                    num.Add(numbers[i]);
                    
                }
                num.Add(numbers[0]);
                num.Reverse();      
            }
            else if (numbers.Count%2!=0)
            {
                num.Add(numbers[numbers.Count - 1]);
                for (int i = 1; i < numbers.Count/2; i++)
                {
                    num.Add(numbers[i]);
                }
               // num.Add(numbers[numbers.Count / 2 + 1]);
                for (int i = numbers.Count/2; i < numbers.Count-1; i++)
                {
                    num.Add(numbers[i]);
                }
                num.Add(numbers[0]);
                num.Reverse();
            }
            
            
           
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
