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
            var inputline = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine().Split().ToArray();
            while (!command[0].Equals("end"))
            {
                List<string> TempList = new List<string>();
                var start = 0;
                var count = 0;

                switch (command[0])
                {
                    case "reverse":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (start < 0 || start>=inputline.Count||count<0||start+count>inputline.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        TempList = inputline.
                            Skip(start).
                            Take(count).
                            Reverse().
                            ToList();
                        inputline.RemoveRange(start, count);
                        inputline.InsertRange(start, TempList);
                        break;
                    case "sort":
                        start = int.Parse(command[2]);
                         count = int.Parse(command[4]);
                        if (start < 0 || start >= inputline.Count || count < 0 || start + count >inputline.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        TempList = inputline.
                            Skip(start).
                            Take(count).
                            OrderBy(str=>str).
                            ToList();
                        inputline.RemoveRange(start, count);
                        inputline.InsertRange(start,TempList);
                        break;
                    case "rollLeft":
                        count = int.Parse(command[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        for (int i = 0; i < count%inputline.Count ; i++)
                        {
                           
                            var firstChar = inputline[0];
                            inputline.RemoveAt(0);
                            inputline.Add(firstChar);
                        }
                        break;
                    case "rollRight":

                        count = int.Parse(command[1]);
                        if (count<0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        for (int i = 0; i < count%inputline.Count; i++)
                        {
                            var lastChar = inputline[inputline.Count-1];
                            inputline.RemoveAt(inputline.Count - 1);
                            inputline.Insert(0,lastChar);
                        }
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine("[{0}]",string.Join(", ",inputline));
        }
    }
}
