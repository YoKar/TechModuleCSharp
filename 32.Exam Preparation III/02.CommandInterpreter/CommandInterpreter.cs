using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {

            var inputLine = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            var finalList = new List<string>();
            finalList = inputLine;
             var command = Console.ReadLine();
            while (true)
            {

                if (command == "end")
                {

                    break;
                }
                var tokens = command.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens[0] == "reverse" || tokens[0] == "sort")
                {
                    if (int.Parse(tokens[2]) < 0 || int.Parse(tokens[2]) > inputLine.Count - 1 || int.Parse(tokens[4]) > inputLine.Count - 1 || int.Parse(tokens[4]) < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                    var startPosiction = int.Parse(tokens[2]);
                    var endPosition = int.Parse(tokens[4]);
                    if (tokens[0] == "reverse")
                    {
                        var ReversetList = inputLine.GetRange(startPosiction, endPosition);
                        ReversetList.Reverse();
                        finalList.RemoveRange(startPosiction, endPosition);
                        finalList.InsertRange(startPosiction, ReversetList);
                    }
                    else
                    {
                        var SortedList = inputLine.GetRange(startPosiction, endPosition);
                        SortedList.Sort();
                        finalList.RemoveRange(startPosiction, endPosition);
                        finalList.InsertRange(startPosiction, SortedList);
                    }
                }
                if (tokens[0] == "rollLeft" || tokens[0] == "rollRight")
                {
                    if (int.Parse(tokens[1]) < 0 )
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                    var count = int.Parse(tokens[1]);

                    if (tokens[0] == "rollLeft")
                    {
                        count %= finalList.Count;
                        var LeftTakenIndexes = finalList.GetRange(0, count);
                        for (int i = count; i < finalList.Count; i++)
                        {
                            finalList[i - count] = finalList[i];
                        }

                        for (int i = finalList.Count - count; i < finalList.Count; i++)
                        {
                            finalList[i] = default(string);

                        }
                        var index = finalList.IndexOf(null);
                        finalList.InsertRange(index, LeftTakenIndexes);
                        index = finalList.IndexOf(null);
                        finalList.RemoveRange(index, finalList.Count - index);
                    }
                    else
                    {
                        count %= finalList.Count;
                        var RightTakenIndexes = finalList.GetRange((finalList.Count - count), count);
                        for (int i = finalList.Count - count - 1; i >= 0; i--)
                        {
                            finalList[i + count] = finalList[i];
                        }

                        for (int i = 0; i < count; i++)
                        {
                            finalList[i] = default(string);
                        }
                        var index = finalList.IndexOf(null);
                        finalList.InsertRange(index, RightTakenIndexes);
                        index = finalList.IndexOf(null);

                        finalList.RemoveRange(index, count);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", finalList));
        }
    }
}
