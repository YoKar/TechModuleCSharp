using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSONParse
{
    class JSONParse
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var tokens = inputLine.Split("{}".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var ListOfStudents = new List<string>();
            var FloatenLIst = new List<string>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (!(tokens[i]=="["||tokens[i]==","|| tokens[i] == "]"))
                {
                    ListOfStudents.Add(tokens[i]);
                }
            }
            for (int i = 0; i < ListOfStudents.Count; i++)
            {
                var paramses = ListOfStudents[i].Split(":".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var name = paramses[1].Split("\",".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var age = paramses[2].Split(",".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var trueGrades = paramses[3].Split("[]".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var trueName = name[0];
                var trueAge = age[0];
                var WNUll = string.Join("",trueGrades);
                if (WNUll==string.Empty)
                {
                    FloatenLIst.Add(string.Join("", trueName) + " : " + trueAge + " -> " + "None");
                }
                else
                {
                    FloatenLIst.Add(string.Join("", trueName) + " : " + trueAge + " -> " + string.Join("", trueGrades));
                }
                
            }
            foreach (var words  in FloatenLIst)
            {
                Console.WriteLine(words);
            }
        }
    }
}
