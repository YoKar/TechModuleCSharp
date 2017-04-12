using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Commits
{
    class Commits
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var pattern = @"https:\/\/github.com\/([A-z0-9]*-*[0-9]*)\/([A-z_-]*)\/(.+?)\/(\b[a-f0-9a-f]+),(.+?),([0-9]+),([0-9]+)";
            Regex regex = new Regex(pattern);
            SortedDictionary<string, SortedDictionary<string, List<string>>> DictionatyReg = new SortedDictionary<string, SortedDictionary<string,List<string>>>();
            Dictionary<string,Dictionary<int,int>> TotalDic = new Dictionary<string,Dictionary<int,int>>();
            while (inputLine != "git push")
            {
                var name = string.Empty;
                var repo = string.Empty;
                var commit = string.Empty;
                var hash = string.Empty;
                var messege = string.Empty;
                var additions = 0;
                var deletions = 0;
                MatchCollection matches = regex.Matches(inputLine);
                foreach (Match item in matches)
                {
                    name = item.Groups[1].Value;
                    repo = item.Groups[2].Value;
                    commit = item.Groups[3].Value;
                    hash = item.Groups[4].Value;
                    messege = item.Groups[5].Value;
                    additions = int.Parse(item.Groups[6].Value);
                    deletions = int.Parse(item.Groups[7].Value);
                }
                if (name!=string.Empty&&repo!=string.Empty)
                {
                    if (!DictionatyReg.ContainsKey(name))
                    {
                        DictionatyReg[name] = new SortedDictionary<string, List<string>>();
                    }
                    if (!DictionatyReg[name].ContainsKey(repo))
                    {
                        DictionatyReg[name][repo] = new List<string>();
                    }
                    DictionatyReg[name][repo].Add(commit + " " + hash + ": " + messege + " (" + additions + " additions, " + deletions + " deletions)");
                    if (!TotalDic.ContainsKey(name))
                    {
                        TotalDic[name] = new Dictionary<int, int>();

                    }

                    TotalDic[name].Add(additions, deletions);
                }
                inputLine = Console.ReadLine();
            }
            foreach (var item in DictionatyReg)
            {
                Console.WriteLine("{0}:",item.Key);
                foreach (var valu in item.Value)
                {
                    Console.WriteLine("  {0}:",valu.Key);
                    foreach (var v in valu.Value)
                    {
                        Console.WriteLine("    {0}",v);
                    }
                    if (TotalDic.ContainsKey(item.Key))
                    {
                        int KayInt = 0;
                        int ValueInt = 0;
                        
                            foreach (var kay in TotalDic[item.Key])
                            {
                                KayInt += kay.Key;
                                ValueInt += kay.Value;
                            }
                        
                        Console.WriteLine("    Total: {0} additions, {1} deletions", KayInt, ValueInt);
                    }
                }
                
                
            }
        }
    }
}