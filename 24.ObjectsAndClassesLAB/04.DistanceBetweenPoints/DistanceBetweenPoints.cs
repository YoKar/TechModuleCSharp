using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            var firstDigits = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var secondDigits = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point p1 = new Point() { x= firstDigits[0] ,y= firstDigits[1] };
            Point p2 = new Point() { x= secondDigits[0] ,y= secondDigits[1] };

            Console.WriteLine("{0:f3}",CalcDistance(p1, p2)); 


        }

        private static double CalcDistance(Point p1 , Point p2)
        {
            var sideA = p1.x - p2.x;
            var sideB = p1.y - p2.y;
            var sideC = Math.Sqrt(Math.Pow(sideA,2)+ Math.Pow(sideB,2));
            return sideC;
        }
    }
}
