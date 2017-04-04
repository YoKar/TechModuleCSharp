using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Points
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string print()
        {
            return $"({X}, {Y})";
        }
    }
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var points = new List<Points>();
            SplitPoints();
            for (int i = 0; i < n; i++)
            {
                var currentPOint = SplitPoints();
                points.Add(currentPOint);
            }
            var minValue = double.MaxValue;
            Points firstPointsss = null;
            Points secondPointResult = null;

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    var firstPont = points[i];
                    var secondPOints = points[j];
                    var distance = CalcDistance(firstPont, secondPOints);
                    if (distance<minValue)
                    {
                        minValue = distance;
                        firstPointsss = firstPont;
                        secondPointResult = secondPOints;
                    }
                }
            }
            Console.WriteLine("{0:f3}",minValue);
            Console.WriteLine(firstPointsss.print());
            Console.WriteLine(secondPointResult.print());
            
        }

        private static Points SplitPoints()
        {
            var CurrentPOints = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            return new Points
            {
                X = CurrentPOints[0],
                Y = CurrentPOints[1]

            };
            

        }
        private static double CalcDistance(Points p1 , Points p2)
        {
            var sideA = p1.X - p2.X;
            var sideB = p1.Y - p2.Y;
            var sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return sideC;
        }
    }
}
