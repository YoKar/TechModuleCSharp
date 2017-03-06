using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var NumLIst = new List<int>();
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (var num in s)
            {
                NumLIst.Add(num);
            }
            for (int i = 0; i < N-1; i++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var counter = 0;
                    foreach (var num in numbers)
                    {
                   
                        if (NumLIst[counter]>num)
                        {
                            NumLIst.RemoveAt(NumLIst[counter]);
                            NumLIst.Insert(NumLIst[counter + 1], num);
                        }
                    else
                    {
                        NumLIst.Add(num);
                    }
                    counter++;
                    }
                    //if (numbers[k]<=numbers[k+1])
                    //{
                    //    NumLIst.Add(numbers[k]);
                    //    if (numbers[numbers.Count-1]>numbers[numbers.Count-2]&&k==numbers.Count-2)
                    //    {
                    //        NumLIst.Add(numbers[numbers.Count - 1]);
                    //    }
                    //}
                    //else
                    //{
                    //    for (int j = k; j < NumLIst.Count; j++)
                    //    {
                    //        NumLIst.RemoveAt(j);
                    //    }
                    //    break;
                    //}
                }
            }
            Console.WriteLine(string.Join(" ",NumLIst));
        }
    }
}
