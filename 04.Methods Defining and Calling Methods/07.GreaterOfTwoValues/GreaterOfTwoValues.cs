using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type =="int" )
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int greaterOfTwoNumber = PrintGreaterNumber(num1 , num2);
                Console.WriteLine(greaterOfTwoNumber);
            }
            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                char greaterChar = PrintGreaterChar(char1,char2);
                Console.WriteLine(greaterChar);
            }
            else if (type == "string")
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();
                string greaterString = PrintGreaterString(string1 , string2);
                Console.WriteLine(greaterString);
            }
        }

        private static string PrintGreaterString(string a , string b)
        {
            string result = "";
            if (a.CompareTo(b)>=0)
            {
                result = a; 
            }
            else
            {
                result = b;
            }
            return result;
        }

        private static char PrintGreaterChar(char a , char b)
        {
            char result = ' ';
            if (a>b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }

        static int PrintGreaterNumber(int a , int b)
        {
            int result = 0;
            if (a>b)
            {
                 result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
    }
}
