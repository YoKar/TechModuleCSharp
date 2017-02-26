using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blackLIsts = Console.ReadLine().Split(' ');
            var playLists = new List<string>();
            bool isTrue = true;
            var song = Console.ReadLine();
            while (song != "end")
            {
                foreach (var word in blackLIsts)
                {
                    if (!song.Contains(word))
                    {
                        isTrue = true;
                       
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }
              
                if (isTrue)
                {
                    playLists.Add(song);
                }
                song = Console.ReadLine();
            }
            playLists.Sort();
            Console.WriteLine(string.Join("\n", playLists));
        }
    }
}
