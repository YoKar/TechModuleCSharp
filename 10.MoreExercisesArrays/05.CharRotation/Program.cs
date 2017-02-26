using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var leters = Console.ReadLine().ToCharArray();
            int[] numbers = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string Words = string.Empty;
            for (int i = 0; i < leters.Length; i++)
            {
               
                if (numbers[i]%2==0)
                {
                    if (leters[i]>numbers[i])
                    {
                        Words += (char)((leters[i]) - numbers[i]);
                        
                    }
                    else
                    {
                        Words += (char)( numbers[i]-leters[i]);
                      
                    }
                  }
                else if (numbers[i]%2==1)
                {
                    if (leters[i]>numbers[i])
                    {
                        Words += (char)((leters[i]) + numbers[i]);
                        
                    }
                    else
                    {
                        Words += (char)(numbers[i] + leters[i]);
                       
                    }
                }
            }
            Console.WriteLine(Words);
        }
    }
}
