using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Crossfire
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            
            
            var BroadCastList = new List<string>();
            var MeesegList = new List<string>();
            while (inputLine!= "Hornet is Green")
            {
                var tokens = inputLine.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length>3|| tokens[2].Contains('@')|| tokens[2].Contains('!')|| tokens[2].Contains('$'))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
               
                var num = 0;
                if (int.TryParse(tokens[0],out num))
                {
                    var FirstQuery =tokens[0].ToList();
                    FirstQuery.Reverse();
                    var secondQuery = tokens[2];
                    MeesegList.Add(string.Join("", FirstQuery) + " -> " + secondQuery);
                   
                }
                else
                {
                    var secondQuery = new List<char>();
                    var FirstQuery = tokens[0];
                    foreach (var charr in tokens[2])
                    {
                        secondQuery.Add(charr);
                    }
                    
                    var CorectedList = new List<char>();
                    foreach (var letter in secondQuery)
                    {
                        if (char.IsUpper(letter))
                        {
                            var let = char.ToLower(letter);
                            CorectedList.Add(let);
                        }
                        else
                        {
                            var up = char.ToUpper(letter);
                            CorectedList.Add(up);
                        }
                    }

                    BroadCastList.Add(string.Join("", CorectedList)+" -> "+FirstQuery);
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (BroadCastList.Count>0)
            {
               
                foreach (var item in BroadCastList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (MeesegList.Count>0)
            {
                foreach (var item in MeesegList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
