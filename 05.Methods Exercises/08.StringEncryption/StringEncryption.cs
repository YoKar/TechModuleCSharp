using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.StringEncryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                var encrypted = Ecrypting(letter);
                 result += encrypted;
              
            }
            Console.WriteLine(result);
        }

        static string Ecrypting(char letter)
        {
            int digit = (int)letter;
            int lasttDigit = digit % 10;
            int FirstDigit = digit;
            while (FirstDigit >= 10) 
            {
                FirstDigit /= 10;
            }
           char endChar = Convert.ToChar(digit - FirstDigit);
              char startChar = Convert.ToChar(digit + lasttDigit);
            var result = $"{startChar}{FirstDigit}{lasttDigit}{endChar}";
            return result;
            }
    }
}
