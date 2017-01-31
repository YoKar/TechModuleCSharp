using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesText
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool sumOfNUm = true;
            int a = 0;
            int b = 0;
            for (int i =1; i <= num; i++)
             {
                a = i % 10;
                b = i/ 10;
                if (a+b==5||a+b==7||a+b==11)
                {
                    sumOfNUm = true;
                }
                else
                {
                    sumOfNUm = false;
                }
                Console.WriteLine("{0} -> {1}", i , sumOfNUm);
               
            }
            
            
        }
    }
}
