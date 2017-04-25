using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_sMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<leftPart>\d+)(?<messege>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]*)$";
            var listOfNumbers = new List<int>();
            while (true)
            {
                var inputLine = Console.ReadLine();
               
                if (inputLine== "Over!")
                {
                    break;
                }
                var lenghtOfTheMessege = int.Parse(Console.ReadLine());
                var match = Regex.Match(inputLine, pattern);
                if (!match.Success)
                {
                    continue;
                }
                var leftPart = match.Groups["leftPart"].Value;
                var messege = match.Groups["messege"].Value;
                var rightPart = match.Groups["rightPart"].Value;
                if (lenghtOfTheMessege>messege.Length|| lenghtOfTheMessege < messege.Length)
                {
                    continue;
                }
                var indexes = string.Empty;
                var leftRight = leftPart+rightPart;
                foreach (var item in leftRight)
                {
                    int num;
                    var validIndex = int.TryParse(item.ToString(), out num);
                    var validLenght = num < messege.Length && num >= 0;
                    if (validIndex&&validLenght)
                    {
                        var character = messege[num];
                        indexes += character;
                    }
                    else
                    {
                        indexes += " ";
                    }
                   
                }
                Console.WriteLine($"{messege} == {indexes}");
            }
        }
    }
}
