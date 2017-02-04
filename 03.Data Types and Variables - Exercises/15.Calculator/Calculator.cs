using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operend = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (operend=='-')
            {
                Console.WriteLine("{0} - {1} = {2}",firstNum,secondNum,(firstNum-(secondNum)));
            }
            else if (operend=='+')
            {
                Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, (firstNum + (secondNum)));
            }
            else if (operend=='*')
            {
                Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, (firstNum * (secondNum)));
            }
            else if (operend=='/')
            {
                Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, (firstNum / (secondNum)));
            }
        }
    }
}
