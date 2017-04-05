using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine();
            
            var LastList = new List<string>();
            
            
            while (inputLIne!="end")
            {
                var leftLIst = new List<string>();
                var rightList = new List<string>();
                var FinalList = new List<string>();
                var counter = 0;
                bool flasee = true;
                var text = string.Empty;
                var tokens = inputLIne.Split(new[] { '-', '>' },StringSplitOptions.RemoveEmptyEntries);
                leftLIst = tokens[0].Split(" ".ToArray(),StringSplitOptions.RemoveEmptyEntries).ToList();
                rightList = tokens[1].Split(", ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var words in leftLIst)
                {
                    FinalList.Add(words);
                }
                foreach (var word in FinalList)
                {

                    try
                    {
                        var indexations = word.Split("{}.".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        counter = indexations[0];
                    }
                    catch (Exception)
                    {
                       
                   
                            flasee = false;
                        
                    }
                        
                   
                    
                    var index = 0;
                    if (word == "{" + counter + "}"|| word == "{" + counter + "}.")
                    {
                        if (word == "{" + counter + "}.")
                        {
                            index = leftLIst.IndexOf(word);
                            leftLIst.Insert(index, rightList[counter]+".");
                            leftLIst.Remove(word);
                        }
                        else
                        {
                            index = leftLIst.IndexOf(word);
                            leftLIst.Insert(index, rightList[counter]);
                            leftLIst.Remove(word);
                        }
                        if (!flasee)
                        {
                            counter++;
                        }
                    }
                    

                }
                foreach (var item in leftLIst)
                {
                    text +=" "+ item;
                }
                inputLIne = Console.ReadLine();
                LastList.Add(text);
            }
            Console.WriteLine(string.Join("\n ",LastList));
        }
    }
}
