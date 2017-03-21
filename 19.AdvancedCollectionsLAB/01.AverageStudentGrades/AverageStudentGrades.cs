using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var StudentGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var NameAndGrade = Console.ReadLine();
                var tokens = NameAndGrade.Split(' ');
                var name = tokens[0];
                var grade =double.Parse (tokens[1]);
                if (!StudentGrades.ContainsKey(name))
                {
                    StudentGrades[name] = new List<double>();
                    StudentGrades[name].Add(grade);
                }
                else
                {
                    StudentGrades[name].Add(grade);
                }
            }
            foreach (var itemPart in StudentGrades)
            {
                var name = itemPart.Key;
                var grades =itemPart.Value;
                var averege = grades.Average();
                Console.Write($"{name} -> ");
                foreach (var item in grades)
                {
                    Console.Write("{0:f2} ",item);
                }
                Console.WriteLine("(avg: {0:f2})",averege);
            }
        }
    }
}
