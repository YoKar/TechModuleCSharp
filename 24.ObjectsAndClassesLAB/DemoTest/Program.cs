using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            var BlackWords = Console.ReadLine().Split(' ').ToArray();
            var words = Console.ReadLine();
       
            var fileNames = new List<string>();
            var Exist = false;
            if (BlackWords[0] != "-" )
            {
                while (words != "end")
                {

                    var w = words.Split(". -_".ToArray(), StringSplitOptions.RemoveEmptyEntries);

                    foreach (var item in w)
                    {
                        if (BlackWords.Contains(item))
                        {
                            Exist = false;
                            break;
                        }
                        else
                        {
                            Exist = true;
                        }
                    }
                    if (Exist)
                    {
                        fileNames.Add(words);
                    }
                    words = Console.ReadLine();
                }
                fileNames.Sort();
                foreach (var file in fileNames)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                while (words != "end")
                {

                    var w = words.Split(". _".ToArray(), StringSplitOptions.RemoveEmptyEntries);

                    foreach (var item in w)
                    {
                        if (BlackWords.Contains(item))
                        {
                            Exist = false;
                            break;
                        }
                        else
                        {
                            Exist = true;
                        }
                    }
                    if (Exist)
                    {
                        fileNames.Add(words);
                    }
                    words = Console.ReadLine();
                }
                fileNames.Sort();
                foreach (var file in fileNames)
                {
                    Console.WriteLine(file);
                }
            }
           
        }
    }
}
