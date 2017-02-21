using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TriangleFormations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var ValidTriangle = a + b > c;
            var ValidTriangle2 = b + c > a;
            var ValidTrianfle3 = a + c > b;
            var rightTriangleC = a * a + b * b == c * c;
            var rightTriangleA = b * b + c * c == a * a;
            var rightTriangleB = a * a + c * c == b * b;

            bool isValidTriangle = true;
            if ((isValidTriangle = ValidTriangle )&& (isValidTriangle = ValidTriangle2) && (isValidTriangle = ValidTrianfle3))
            {
                Console.WriteLine("Triangle is valid.");
                if (rightTriangleC)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (rightTriangleA)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (rightTriangleB)
                {

                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }

            
            }
    }
}
