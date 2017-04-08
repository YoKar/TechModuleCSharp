using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nilapdromes
{
    class Nilapdromes
    {
        static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine();
            var ListString = new List<string>();
            while (inputLIne!="end")
            {
                var rightBorder = inputLIne.Substring(inputLIne.Length / 2);
                var leftBorder = inputLIne.Remove(inputLIne.Length - rightBorder.Length);
                var border = string.Empty;
                var center = string.Empty;
                if (leftBorder!=rightBorder)
                {
                    var counter = 0;
                    if (inputLIne.Length%2==0)
                    {
                         counter = 1;
                        while (leftBorder != rightBorder)
                        {
                            leftBorder = leftBorder.Remove(leftBorder.Length - counter);
                            rightBorder = rightBorder.Substring(counter);
                        }
                    }
                    
                    else
                    {
                        var coun = 0;
                        while (leftBorder != rightBorder)
                        {
                            
                            if (coun!=0)
                            {
                                leftBorder = leftBorder.Remove(leftBorder.Length - counter);
                            }
                            counter = 1;
                            rightBorder = rightBorder.Substring(counter);
                            coun++;
                        }
                    }
                    if (!(rightBorder.Length<=0 && leftBorder.Length<=0))
                    {
                        border = rightBorder;
                        center = inputLIne.Substring(border.Length);
                        center = center.Remove(center.Length - border.Length);
                        ListString.Add(center + border + center);
                    }
                    
                }
                
                inputLIne = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n",ListString));
        }
    }
}
