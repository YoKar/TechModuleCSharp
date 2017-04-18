using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Files
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> Dicitionary = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> Parm = new Dictionary<string, long>();
            for (int i = 0; i < N; i++)
            {
                var inputLine = Console.ReadLine().Split('\\');
                var folder = inputLine[0];
                var lastTokens = inputLine[inputLine.Length - 1].Split(';');
                var fileName = lastTokens[0];
                var fileSize = long.Parse(lastTokens[1]);

                if (Dicitionary.ContainsKey(folder))
                {
                    Dicitionary[folder][fileName] = fileSize;
                }
                else
                {
                    Parm = new Dictionary<string, long>();
                    Parm[fileName] = fileSize;
                    Dicitionary[folder] = Parm;
                }

            }
            var command = Console.ReadLine().Split();
            var File = command[0];
            var Foldered = command[2];
            var f = File.Split('.');
            bool breackPoint = false;
            if (Dicitionary.ContainsKey(Foldered))
            {
                Parm = Dicitionary[Foldered].
               OrderByDescending(x => x.Value).
               ThenBy(x => x.Key).
               ToDictionary(z => z.Key, z => z.Value);

                foreach (var item in Parm)
                {
                    breackPoint = false;
                    if (item.Key.Contains(f[0]))
                    {
                        Console.WriteLine("{0} - {1} KB", item.Key, item.Value);
                    }
                    else
                    {
                        breackPoint = true;
                    }
                }
            }
            else
            {
                if (breackPoint)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

        }
    }
}
