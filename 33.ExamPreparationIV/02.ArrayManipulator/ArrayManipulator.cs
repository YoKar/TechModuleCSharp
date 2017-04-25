using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                var tokens = command.Split().ToArray();
                switch (tokens[0])
                {
                    case "exchange":
                        if (int.Parse(tokens[1]) >= inputArray.Count || int.Parse(tokens[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            inputArray = ExchangeMethotd(inputArray, int.Parse(tokens[1]));

                        }
                        break;
                    case "max":
                        MaxEvenOrOddMethod(tokens[0],tokens[1],inputArray);
                        break;
                    case "min":
                        minEvenOrOddMethod(tokens[1], inputArray);
                        break;
                    case "first":
                        FirstEvenOrOddMethod(int.Parse(tokens[1]), tokens[2], inputArray);
                        break;
                    case "last":
                        LastEvenOrOddMethod(int.Parse(tokens[1]), tokens[2], inputArray);
                        break;
                }
            }
            Console.WriteLine("[{0}]",string.Join(", ",inputArray));
        }

        private static void LastEvenOrOddMethod(int count, string EvenOrODD, List<int> arr)
        {
            if (count > arr.Count )
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (EvenOrODD == "even")
                {
                    var evenNums = arr.Where(a => a % 2 == 0).OrderByDescending(a=>a).ToList();
                    if (evenNums.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", evenNums.Take(count)));
                    }
                }
                else
                {
                    var evenNums = arr.Where(a => a % 2 == 1).OrderByDescending(a => a).ToList();
                    if (evenNums.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", evenNums.Take(count)));
                    }
                }
            }
        }

        private static void FirstEvenOrOddMethod(int count, string EvenOrODD,  List<int> arr)
        {
            if (count>arr.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (EvenOrODD=="even")
                {
                    var evenNums = arr.Where(a => a % 2 == 0).ToList();
                    if (evenNums.Count==0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", evenNums.Take(count)));
                    }
                  }
                else
                {
                    var evenNums = arr.Where(a => a % 2 == 1).ToList();
                    if (evenNums.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", evenNums.Take(count)));
                    }
                }
            }
        }

        private static void minEvenOrOddMethod(string EvenOrOdd, List<int> arr)
        {
            if (EvenOrOdd == "even")
            {
                var evenList = arr.Where(a => a % 2 == 0).ToList();
                if (evenList.Count == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxNum = evenList.Min();
                    Console.WriteLine(arr.LastIndexOf(maxNum));
                }
            }
            else
            {

                var evenList = arr.Where(a => a % 2 == 1).ToList();
                if (evenList.Count == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxNum = evenList.Min();
                    Console.WriteLine(arr.LastIndexOf(maxNum));
                }
            }
        }

        private static void MaxEvenOrOddMethod(string Max, string EvenOrOdd, List<int> arr)
        {
            if (EvenOrOdd=="even")
            {
                var evenList = arr.Where(a => a % 2 == 0).ToList();
                if (evenList.Count==0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxNum = evenList.Max();
                    Console.WriteLine(arr.LastIndexOf(maxNum));
                }
            }
            else
            {

                var evenList = arr.Where(a => a % 2 == 1).ToList();
                if (evenList.Count == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxNum = evenList.Max();
                    Console.WriteLine(arr.LastIndexOf(maxNum));
                }
            }
        }

        private static List<int> ExchangeMethotd(List<int> arr, int index)
        {

            var leftSide = arr.Take(index + 1).ToList();
            arr.RemoveRange(0, index + 1);
            arr.InsertRange(arr.Count, leftSide);
            return arr;
        }
    }
}
