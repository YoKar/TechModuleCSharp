using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Crossfire
{
    class HornetComm
    {
        static void Main(string[] args)
        {
           
            var MessegesList = new List<string>();
            var BroadcastList = new List<string>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Hornet is Green")
                {
                    break;
                }
                var tokens = inputLine.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 2)
                {
                    continue;
                }
                var firstQuery = tokens[0];
                var secondQuerry = tokens[1];
                if (firstQuery.All(char.IsDigit)
                    && secondQuerry.All(char.IsLetterOrDigit))
                {
                    string reversedMeseges = new string(firstQuery.Reverse().ToArray());
                    MessegesList.Add($"{reversedMeseges} -> {secondQuerry}");
                }
                else if (firstQuery.All(a => !char.IsDigit(a)) &&
                    secondQuerry.All(char.IsLetterOrDigit))
                {
                    var transformedChars = new StringBuilder();
                    foreach (var item in secondQuerry)
                    {
                        if (char.IsUpper(item))
                        {
                            transformedChars.Append(item.ToString().ToLower());
                        }
                        else if (char.IsLower(item))
                        {
                            transformedChars.Append(item.ToString().ToUpper());
                        }
                        else
                        {
                            transformedChars.Append(item);
                        }
                    }
                    BroadcastList.Add($"{transformedChars} -> {firstQuery}");
                }
               
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(BroadcastList.Any()
                ? string.Join(Environment.NewLine, BroadcastList)
                : "None");
            Console.WriteLine("Messages:");
            Console.WriteLine(MessegesList.Any()
                ? string.Join(Environment.NewLine, MessegesList)
                : "None");
        }
    }
}
