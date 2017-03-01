using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            var strNums = Console.ReadLine();
            var numbers = new List<int>();
            bool bangsProblem = true;
            var lastOne = 0;
            while (strNums!="stop")
            {
                if (strNums!="bang")
                {
                    var n = Convert.ToInt32(strNums);
                    numbers.Insert(0,Math.Abs(n)); 
                }
                else
                {
                    if (numbers.Count==0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastOne}");
                        bangsProblem = false;
                    }
                    else
                    {
                        foreach (var num in numbers)
                        {
                            if (num <= numbers.Average())
                            {
                                Console.WriteLine($"shot {num}");
                                numbers.Remove(num);
                                lastOne = num;
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    numbers[i] -= 1;
                                }
                                break;
                            }
                        }
                    }
                    
                }
                if (bangsProblem==false)
                {
                    break;
                }
                strNums = Console.ReadLine();
            }
            if (strNums=="stop")
            {
                if (numbers.Count>0)
                {
                    Console.WriteLine($"survivors: {string.Join(" ",numbers)}");
                }
                else
                {
                    Console.WriteLine($"you shot them all. last one was {lastOne}");
                }
            }
        }
    }
}
