using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batterie
{
    class Batterie
    {
        static void Main(string[] args)
        {
            var firstNUms = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var hours = int.Parse(Console.ReadLine());
            var counterOfFirst = 0;
            var CounterOfSecond = 0;
           
            for (int i = 0; i < firstNUms.Count; i++)
            {
                bool isDeadOrNot = true;
                double finaMaH = firstNUms[counterOfFirst];
                var deadHours = 0;
                double Divined = firstNUms[counterOfFirst];
                for (int k = 0; k < hours; k++)
                {
                   
                    finaMaH -=  secondList[CounterOfSecond];
                    
                    if (finaMaH<0)
                    {
                        if ((firstNUms[counterOfFirst] / secondList[CounterOfSecond]) > k)
                        {
                            deadHours++;
                            
                        }
                        isDeadOrNot = false;
                      
                        break;
                    }
                    deadHours++;
                }
                if (isDeadOrNot==false)
                {
                    
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", counterOfFirst+1,deadHours);
                    
                }
                else
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", counterOfFirst + 1,   finaMaH,((finaMaH*100)/Divined));
                }
                counterOfFirst++;
                CounterOfSecond++;
            }
            
        }
    }
}
