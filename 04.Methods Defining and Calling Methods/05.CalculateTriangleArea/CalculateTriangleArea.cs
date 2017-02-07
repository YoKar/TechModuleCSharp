using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
           double area= PrintTriangleArea(width,heigth);
            Console.WriteLine(area);
        }

         static double PrintTriangleArea(double a , double b)
        {
            return (a * b) / 2;
        }
    }
}
