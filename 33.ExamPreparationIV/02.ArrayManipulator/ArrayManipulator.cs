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
            var arr = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                var command = inputLine.Split(' ');
                switch (command[0])
                {
                    case "exchange":
                        arr = Exchange(arr, int.Parse(command[1]));
                        break;
                    case "max":
                        MaxMeth(arr, command[1]);
                        break;
                    case "min":
                        MinMeth(arr, command[1]);
                        break;
                    case "first":
                        FirstCounterMeth(arr, command[1], command[2]);
                        break;
                    case "last":
                        LastCounterMeth(arr, command[1], command[2]);
                        break;
                }

            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        private static void LastCounterMeth(string[] arr, string index, string EvenOrOdd)
        {
            var list = new List<int>();
            var theIndex = int.Parse(index);
            if (theIndex < 0 || theIndex > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (EvenOrOdd == "even")
                {
                    foreach (var item in arr)
                    {
                        if (int.Parse(item) % 2 == 0)
                        {
                            list.Add(int.Parse(item));
                        }
                    }
                    if (list.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        list.Reverse();
                        var last = list.Take(theIndex);
                        last.Reverse();
                        Console.WriteLine("[{0}]", string.Join(", ", last));
                    }
                }
                else if (EvenOrOdd == "odd")
                {
                    foreach (var item in arr)
                    {
                        if (int.Parse(item) % 2 == 1)
                        {
                            list.Add(int.Parse(item));
                        }
                    }
                    if (list.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        list.Reverse();
                        var last = list.Take(theIndex);
                        last.Reverse();
                        Console.WriteLine("[{0}]", string.Join(", ", last));
                    }
                }

            }
        }

        private static void FirstCounterMeth(string[] arr, string index, string EvenOrOdd)
        {
            var list = new List<int>();
            var theIndex = int.Parse(index);
            if (theIndex < 0 || theIndex > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (EvenOrOdd == "even")
                {
                    foreach (var item in arr)
                    {
                        if (int.Parse(item)%2==0)
                        {
                            list.Add(int.Parse(item));
                        }
                    }
                    if (list.Count==0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("[{0}]",string.Join(", ",list.Take(theIndex)));
                    }
                }
                else if (EvenOrOdd == "odd")
                {
                    foreach (var item in arr)
                    {
                        if (int.Parse(item) % 2 == 1)
                        {
                            list.Add(int.Parse(item));
                        }
                    }
                    if (list.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", list.Take(theIndex)));
                    }
                }

            }
        }

        private static void MinMeth(string[] arr, string EvenOrOdd)
        {
            var result = new List<int>();
            var theIndex = 0;

            if (EvenOrOdd == "odd")
            {
                foreach (var item in arr)
                {
                    if (int.Parse(item) % 2 == 1)
                    {
                        result.Add(int.Parse(item));
                    }

                }
                if (result.Any())
                {
                    theIndex = result.Where(a => a % 2 == 1).Min();
                    string resultstring = Convert.ToString(theIndex);
                    Console.WriteLine(Array.LastIndexOf(arr, resultstring));
                }
                else
                {
                    Console.WriteLine("No matches");
                }

            }
            else if (EvenOrOdd == "even")
            {
                foreach (var item in arr)
                {
                    if (int.Parse(item) % 2 == 0)
                    {
                        result.Add(int.Parse(item));
                    }

                }
                if (result.Any())
                {
                    theIndex = result.Where(a => a % 2 == 0).Min();
                    string resultstring = Convert.ToString(theIndex);
                    Console.WriteLine(Array.LastIndexOf(arr, resultstring));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void MaxMeth(string[] arr, string EvenOrOdd)
        {
            var result = new List<int>();
            var theIndex = 0;

            if (EvenOrOdd == "odd")
            {
                foreach (var item in arr)
                {
                    if (int.Parse(item) % 2 == 1)
                    {
                        result.Add(int.Parse(item));
                    }

                }
                if (result.Any())
                {
                    theIndex = result.Where(a => a % 2 == 1).Max();
                    string resultstring = Convert.ToString(theIndex);
                    Console.WriteLine(Array.LastIndexOf(arr, resultstring));
                }
                else
                {
                    Console.WriteLine("No matches");
                }

            }
            else if (EvenOrOdd == "even")
            {
                foreach (var item in arr)
                {
                    if (int.Parse(item) % 2 == 0)
                    {
                        result.Add(int.Parse(item));
                    }

                }
                if (result.Any())
                {
                    theIndex = result.Where(a => a % 2 == 0).Max();
                    string resultstring =Convert.ToString( theIndex);
                    Console.WriteLine(Array.LastIndexOf( arr,resultstring));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }


        }

        private static string[] Exchange(string[] arr, int index)
        {
            if (index < 0 || index > arr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            var leftSide = arr.Take(index + 1);
            var rightSide = arr.Skip(index + 1);
            arr = rightSide.Concat(leftSide).ToArray();
            return arr;


        }
    }
}
