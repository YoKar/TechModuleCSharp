using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SerializeString
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            var inputLIne = Console.ReadLine();
            var Hash = new HashSet<char>();
            var listChar = new List<string>();
            foreach (var word in inputLIne)
            {
                Hash.Add(word);
            }
            foreach (var item in Hash)
            {
                listChar.Add(item.ToString());
            }
            var FinalList = new List<string>();
            for (int i = 0; i < listChar.Count; i++)
            {
                string numOfleters = listChar[i] + ":";
                var index = -1;
                for (int k = 0; k < inputLIne.Length; k++)
                {
                    index = inputLIne.IndexOf(listChar[i], index + 1);
                    if (index >= 0)
                    {

                        numOfleters += index + "/";


                    }
                    else
                    {
                        break;
                    }

                }
                FinalList.Add(numOfleters.Remove(numOfleters.Length - 1));
            }
            foreach (var item in FinalList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
