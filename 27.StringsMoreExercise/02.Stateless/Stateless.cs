using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            var FirstInputLIne = Console.ReadLine();
            var SecondInputLine = Console.ReadLine();
            var ListString = new List<string>();
            
            while (true)
            {
                var counter = FirstInputLIne;
                while (SecondInputLine.Length>0)
                {
                    
                    for (int i = 0; i < counter.Length; i++)
                    {
                        var index = -1;
                        if (FirstInputLIne.Contains(SecondInputLine))
                        {
                            index = FirstInputLIne.IndexOf(SecondInputLine);
                            if (index >= 0)
                            {
                                FirstInputLIne = FirstInputLIne.Remove(index, SecondInputLine.Length);
                            }
                          
                        }
                        else
                        {
                            break;
                        }
                    }
                    SecondInputLine = SecondInputLine.Remove(SecondInputLine.Length - 1);
                    if (SecondInputLine.Length>0)
                    {
                       SecondInputLine= SecondInputLine.Substring(1);
                    }
                }
                if (FirstInputLIne==string.Empty)
                {
                    FirstInputLIne = "(void)";
                }
                ListString.Add(FirstInputLIne.Trim());
                FirstInputLIne = Console.ReadLine();
                if (FirstInputLIne== "collapse")
                {
                    break;
                }
                SecondInputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n",ListString));
        }
    }
}
