using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JSONStringify
{
    class JSONStringify
    {
        static void Main(string[] args)
        {
            var inpuLine = Console.ReadLine();
            var listOfStudents = new List<string>();
            while (inpuLine!= "stringify")
            {
                var tokens = inpuLine.Split("->".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var ParamsNameAndAge = tokens[0].Trim().Split(": ".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var name = ParamsNameAndAge[0];
                var age = ParamsNameAndAge[1];
                var Grades = tokens[1].Trim();
                listOfStudents.Add("{name:\"" + name + "\",age:" + age + ",grades:[" + Grades + "]}");
                inpuLine = Console.ReadLine();
            }
            Console.WriteLine("[{0}]",string.Join(",",listOfStudents));
        }
    }
}
